import { Component, OnInit } from '@angular/core';
import { Product } from './model/Product';
import { ProductService } from './services/product.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'front';


  products : Product[] = [];

  /**
   *
   */
  constructor(private productService: ProductService) {}
  ngOnInit(): void {
    this.productService.getProduct().subscribe((result: Product[]) => (this.products = result) )
  }

}
