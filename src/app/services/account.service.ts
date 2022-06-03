import { Injectable } from '@angular/core';


@Injectable()
export class AccountService {

  constructor() { }
  loggendIn=false;
  login(user:User):boolean{
    if (user.userName=="selman" && user.password=="12345"){
         this.loggendIn=true;
      localStorage.setItem("isLogged" ,user.userName)
      return true;


    }
    return false;

  }
  isLoggedİn(){
    return this.loggendIn;

  }
  logout(){
    localStorage.removeItem("isLogged");
    this.loggendIn=false;
     }
}
