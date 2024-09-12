import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: '/cdb-calculator', pathMatch: 'full' },
  { path: 'cdb-calculator', loadChildren: () => import('./cdb-calculator/cdb/cdb.module').then(m => m.CdbModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
