import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CdbCalculatorComponent } from '../cdb-calculator.component';
import { CdbRoutingModule } from './cdb-routing.module';
import { BrowserModule } from '@angular/platform-browser';

@NgModule({
  declarations: [
    CdbCalculatorComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    BrowserModule,
    CdbRoutingModule
  ]
})
export class CdbModule { }
