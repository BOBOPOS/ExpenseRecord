import { Component, OnInit } from '@angular/core';
import { ExpenseItemService} from '../expense-item.service';
import { Observable, of, throwError } from 'rxjs';
import { ExpenseItem} from '../model/expenseItem'

@Component({
  selector: 'app-expense-record',
  templateUrl: './expense-record.component.html',
  styleUrls: ['./expense-record.component.css']
})
export class ExpenseRecordComponent implements OnInit {

  constructor(private ExpenseItemService: ExpenseItemService) { 

  }
  public displayList:ExpenseItem[]= [];
  public fullList:ExpenseItem[]= [];
  ngOnInit(): void {
    this.ExpenseItemService.getAll().subscribe(todo => {
      this.displayList = todo;
      this.fullList = todo;
      
    });
  }
  public description:string = "";
  public type:string = "";
  public amount:number = 0;
  ChangeDesciption(){
    console.log(this.description)
  }
  

}
