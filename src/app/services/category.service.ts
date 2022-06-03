import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from  '@angular/common/http';

import { Observable,throwError } from 'rxjs';
import { tap,catchError } from 'rxjs';
import { category } from '../category/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http : HttpClient) { }
  path!: "../category/:id";
  getCategory(): Observable<category[]> {
    return this.http.get<category[]>(this.path).pipe(
      tap( data=> console.log(JSON.stringify(data))),
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
