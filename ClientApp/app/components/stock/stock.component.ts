import { Http } from '@angular/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormArray, Validators } from "@angular/forms";
import { Observable } from 'rxjs/Observable';

@Component({
    selector: 'stock',
    templateUrl: './stock.component.html'
})
export class StockComponent implements OnInit {

    currencies=['SGD','USD','RMB'];
    actions=['BUY','SELL'];
    stockForm: FormGroup;
    constructor(private http:Http) {
      
    }

    ngOnInit(): void {
       this.stockForm = new FormGroup({
      'stockCode': new FormControl(null,Validators.required),
      'description': new FormControl(null,Validators.required),
      'price': new FormControl(null,Validators.required),            
      'lots': new FormControl(null,Validators.required),
      'currency': new FormControl('SGD',Validators.required),
      'totalValue': new FormControl(null,Validators.required),
      'action': new FormControl('BUY')
    });
}
    onSumbit(){
       console.log(this.stockForm.value);
    }
}
