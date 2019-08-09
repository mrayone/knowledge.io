import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormularioComponent } from './formulario/formulario.component';
import { ListaPermissoesComponent } from './lista-permissoes/lista-permissoes.component';
import { AdicionarPermissaoComponent } from './adicionar-permissao/adicionar-permissao.component';
import { PermissaoRoutingModule } from './permissao-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
@NgModule({
  declarations: [
    FormularioComponent,
    AdicionarPermissaoComponent,
    ListaPermissoesComponent
  ],
  imports: [
    CommonModule,
    PermissaoRoutingModule,
    ReactiveFormsModule,
    NgbModule
  ]
})
export class PermissaoModule { }
