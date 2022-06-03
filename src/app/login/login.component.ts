import { Component, OnInit } from '@angular/core';
import { AccountService } from '../services/account.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
 model: User= new User;

  constructor(private AccountService:AccountService) { }

  ngOnInit(): void {
  }
  login(form:NgForm){
    this.AccountService.login(this.model)
  }

}
