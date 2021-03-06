import { Component, OnInit } from '@angular/core';
import { Perfil } from '../models/perfil';
import { PerfilService } from 'src/app/services/perfil.service';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-lista-perfis',
  templateUrl: './lista-perfis.component.html',
  styleUrls: ['./lista-perfis.component.scss']
})
export class ListaPerfisComponent implements OnInit {

  perfis$: Observable<Perfil[]>;
  constructor(private perfilSerivce: PerfilService, private router: Router) {
  }

  ngOnInit() {
    this.perfis$ = this.perfilSerivce.getTodos()
    .pipe(
      map((perfis) => {
        perfis.map((el) => {
          el.action = {
            view: this.router.createUrlTree(['perfis/detalhes', el.id]).toString(),
            edit: this.router.createUrlTree(['perfis/editar', el.id]).toString(),
            delete: this.router.createUrlTree(['perfis/detalhes', el.id]).toString()
          };
        });
        return perfis;
      })
    );
  }
}
