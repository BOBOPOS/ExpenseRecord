import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { ExpenseItem} from './model/expenseItem'
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class ExpenseItemService {

  todosUrl:string = 'http://localhost:5078';
  constructor(private http:HttpClient) { }

  public expenseItems:ExpenseItem[] = [];

  public getAll(): Observable<ExpenseItem[]> {
    console.log(`${this.todosUrl}/api/items"`)
    return this.http.get<ExpenseItem[]>(`${this.todosUrl}/api/items`)
  }

}
