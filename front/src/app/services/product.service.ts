import { Injectable } from '@angular/core';
import { Product } from '../model/Product';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  url = "Product"

  constructor(private http: HttpClient) { }

  public getProduct() : Observable<Product[]>{
    return this.http.get<Product[]>(`${environment.apiUrl}/${this.url}`);
  }


}
