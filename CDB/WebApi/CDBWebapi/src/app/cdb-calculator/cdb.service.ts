import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CdbService {
  private apiUrl = 'https://localhost:7023/api/Cdb/cdb';

  constructor(private http: HttpClient) {}

  calculaCDB(valor: number, meses: number): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}?valor=${valor}&meses=${meses}`);
  }
}
