import { Injectable } from '@angular/core';
declare let alertify:any;
@Injectable({providedIn:
'root'})
export class AlertifyService {
  error: any;

  constructor() { }

  success(message:string){
  alertify.success(message)


  }


}
