import { Component, OnInit } from '@angular/core';
import { product } from '../product';
import { category } from '../../category/category';
import { CategoryService } from '../../services/category.service';
import { ProductService } from 'src/app/services/product.service';
import { NgForm } from '@angular/forms';
import { AlertifyService } from '../../services/alertify.service';

@Component({
  selector: 'app-product-add-forms1',
  templateUrl: './product-add-forms1.component.html',
  styleUrls: ['./product-add-forms1.component.css'],
  providers:[CategoryService,ProductService]
})
export class ProductAddForms1Component implements OnInit {

  constructor(
    private CategoryService:CategoryService,
    private ProductService:ProductService,
    private AlertifyService:AlertifyService
    ) { }
  model : product= new product();
  categorys!: category[];

  ngOnInit(): void {
    this.CategoryService.getCategory().subscribe(data=>{
      this.categorys=data;
    });
  }
  add(form:NgForm){
    };

  }





