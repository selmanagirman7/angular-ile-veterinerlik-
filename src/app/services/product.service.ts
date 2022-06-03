import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from  '@angular/common/http';
import { product } from '../product/product';
import { Observable,throwError } from 'rxjs';
import { tap,catchError } from 'rxjs';
import { category } from '../category/category';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  product!: product[];

  constructor(private http : HttpClient) { }

  path!: "../product/product.component.ts";

   getProduct(categoryid: any): Observable<product[]> {
     return this.http.get<product[]>(this.path +"?categoryid="+categoryid).pipe(
      tap( data=> console.log(JSON.stringify(this.product= data))),
      catchError(this.handleError),
    );


     }

     handleError(err:HttpErrorResponse){
       let errorMessage=''
       if (err.error instanceof ErrorEvent){
         errorMessage='bir hata oluştu' +err.error.message;

       }else{
         errorMessage='sistemsel bir hata'
       }
       return throwError(errorMessage);

     }
    }

