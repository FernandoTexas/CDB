import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router'; // Importar RouterModule

import { AppComponent } from './app.component';
import { CdbModule } from './cdb-calculator/cdb/cdb.module';

const routes: Routes = [
  // Defina suas rotas aqui
  { path: 'cdb', loadChildren: () => import('./cdb-calculator/cdb/cdb.module').then(m => m.CdbModule) },
  { path: '', redirectTo: '/cdb-calculator', pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    CdbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
