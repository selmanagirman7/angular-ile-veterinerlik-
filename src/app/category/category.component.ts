import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../services/alertify.service';
import { CategoryService } from '../services/category.service';
import { category } from './category';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css'],
  providers :[CategoryService]
})
export class CategoryComponent implements OnInit {

  constructor(private alertifyService:AlertifyService,
    private categoryService:CategoryService) { }
  title="PaTi"
  categorys:category[]=[
    {id:1, name:"kedi"},
    {id:2, name:"köpek"},
    {id:3, name:"balık "},

    {id:5, name:"sürüngenler "},

    {id:6, name:"Mamalar, Yemler,VS"},



  ]

  ngOnInit(): void {
    this.categoryService.getCategory().subscribe(data=>{
      this.categorys=data;
    })
  }

}
