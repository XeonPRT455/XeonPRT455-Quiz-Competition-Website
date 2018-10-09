import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { User } from '../models/user';




@Injectable({
  providedIn: 'root'
})
export class UserServiceService {


  constructor(private http: HttpClient) { }

  
  getQuiz() {
    return this.http.get('https://jsonplaceholder.typicode.com/users');
  }

  getAccountModel(userid: string): Observable<Account> {   
   let para = { userID: userid };   
    return this.http.get<Account>('/api/values', { params: para }); 
   }


}
