import { Component } from '@angular/core';
import { CdbService } from './cdb.service';

@Component({
  selector: 'app-cdb-calculator',
  templateUrl: './cdb-calculator.component.html',
  styleUrls: ['./cdb-calculator.component.scss']
})
export class CdbCalculatorComponent {
  valor: number | null = null;
  meses: number | null = null;
  resultado: any | null = null;

  constructor(private cdbService: CdbService) {}

  calcular() {
    if (this.valor != null && this.meses != null) {
      this.cdbService.calculaCDB(this.valor, this.meses).subscribe(
        (resultado: number) => {
          this.resultado = resultado;
        },
        (error) => {
          console.error('Erro ao calcular o CDB:', error);
        }
      );
    }
  }

}
