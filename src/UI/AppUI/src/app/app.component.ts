import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IProduct } from './nav-bar/Models/Product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'AppUI';
  baseURL = "https://localhost:44328/api/Products/GetProducts";
  products:IProduct[]=[];
  constructor(private http: HttpClient) {
  }
  ngOnInit(): void {
    this.getProducts();
  }
  getProducts() {
    return this.http.get(this.baseURL).subscribe(
      (values:any)=>{
        this.products=values;

        console.log("this.products",this.products);
      }
      );
  }
}
