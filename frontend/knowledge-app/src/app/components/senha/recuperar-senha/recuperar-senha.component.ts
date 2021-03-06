import { Component, OnInit, AfterViewInit, ViewChildren, ElementRef } from '@angular/core';
import { FormGroup, FormControlName, FormControl, Validators } from '@angular/forms';
import { GenericValidator } from 'src/app/Utils/generic-validator';
import { LogInService } from 'src/app/services/log-in.service';
import { Store } from '@ngrx/store';
import { AppState } from 'src/app/store/reducers';
import { InrequestService } from 'src/app/services/inrequest.service';
import { Router } from '@angular/router';
import { Observable, fromEvent, merge } from 'rxjs';
import { mensagensDeErro } from './mensagens-de-erro/mensagens';
import { UsuarioService } from 'src/app/services/usuario.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-recuperar-senha',
  templateUrl: './recuperar-senha.component.html',
  styleUrls: ['./recuperar-senha.component.scss']
})
export class RecuperarSenhaComponent implements OnInit, AfterViewInit {

  recuperaraSenhaForm: FormGroup;

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];
  genericValidator: GenericValidator;
  erros: any = {};

  constructor(private usuarioService: UsuarioService, public inRequestService: InrequestService,
    private router: Router, private toastService: ToastrService) {
    this.genericValidator = new GenericValidator(mensagensDeErro);
  }

  ngOnInit() {
    this.formInit();
  }

  recuperarLogin(): void {
    if (this.recuperaraSenhaForm.valid) {
      this.usuarioService
        .postSolicitarNovaSenha(this.recuperaraSenhaForm.value.username)
        .subscribe(val => {
          this.toastService.success('Solicitação realizada com sucesso! Em até 10 min lhe enviaremos um e-mail.');
        });
    }
  }

  private formInit() {
    this.recuperaraSenhaForm = new FormGroup({
      username: new FormControl('', [Validators.email, Validators.required])
    });
  }

  ngAfterViewInit(): void {
    const controlBlurs: Observable<any>[] = this.formInputElements
      .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(value => {
      this.erros = this.genericValidator.processMessages(this.recuperaraSenhaForm);
    });
  }
}
