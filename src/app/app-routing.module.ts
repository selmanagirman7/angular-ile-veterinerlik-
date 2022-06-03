import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductAddForms1Component } from './product/product-add-forms1/product-add-forms1.component';
import { ProductComponent } from './product/product.component';
import { CategoryComponent } from './category/category.component';
import { LoginComponent } from './login/login.component';
import { LoginGuard } from './login/login.guard';

const routes: Routes = [
  // {path:'products/category/:categoryid',component:ProductComponent},
  {path:'products', component : ProductComponent},
  {path:'product-add', component : ProductAddForms1Component, canActivate:[LoginGuard]},
  {path:'',redirectTo: 'products' , pathMatch :'full'},
  {path : 'products/category/:categoryid' , component : ProductComponent },
  {path:'login', component : LoginComponent},










];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
