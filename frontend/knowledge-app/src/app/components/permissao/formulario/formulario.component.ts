import { Component, OnInit, ViewChildren, ElementRef, AfterViewInit, EventEmitter, Output, Input } from '@angular/core';
import { FormGroup, FormControl, Validators, FormControlName } from '@angular/forms';
import { Permissao } from '../Models/permissao';
import { FormType } from 'src/app/Utils/formType/form-type.enum';
import { merge, Observable, fromEvent } from 'rxjs';
import { GenericValidator } from 'src/app/Utils/generic-validator';
import { mensagensDeErroPermissaoForm } from './mensagens-de-erro/mensagens-de-erro';
import { InrequestService } from 'src/app/services/inrequest.service';


@Component({
  selector: 'app-formulario-permissao',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.scss']
})
export class FormularioComponent implements OnInit, AfterViewInit {

  permissaoForm: FormGroup;
  erros: any = {};
  genericValidator: any;
  @Input() model: Permissao;
  @Input() formType: FormType = FormType.Post;

  @Output() command = new EventEmitter<FormGroup>();
  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];
  constructor( public inRequestService: InrequestService ) {
    this.genericValidator = new GenericValidator(mensagensDeErroPermissaoForm);
    this.model =  new Permissao();
   }

  ngOnInit() {
    this.gerarFormulario();
  }

  gerarFormulario() {
    this.permissaoForm = new FormGroup({
      tipo: new FormControl(this.model.tipo, [
        Validators.required,
        Validators.minLength(3),
        Validators.maxLength(30)
      ]),
      valor: new FormControl(this.model.valor, [
        Validators.required,
        Validators.minLength(3),
        Validators.maxLength(30)
      ]),
    });

    if (this.formType === FormType.Put) {
      this.permissaoForm.addControl('id', new FormControl(this.model.id)
      );
    }
  }

  ngAfterViewInit(): void {
    const controlBlurs: Observable<any>[] = this.formInputElements
      .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(value => {
      this.erros = this.genericValidator.processMessages(this.permissaoForm);
    });
  }

  sendCommand() {
    this.command.emit(this.permissaoForm);
    this.inRequestService.startRequest();
  }

}
