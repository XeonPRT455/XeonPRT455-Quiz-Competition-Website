import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from './home/home.component';
import {QuizComponent} from './quiz/quiz.component';
import {ContactComponent} from './contact/contact.component';
import {LoginComponent} from './login/login.component';
import {AnswerComponent} from './answer/answer.component';
import {ResultComponent} from './result/result.component';
import { from } from 'rxjs';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'quiz',
    component: QuizComponent
  },
  {
    path: 'contact',
    component: ContactComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'answer/:question',
    component: AnswerComponent
  },
  {
    path: 'result',
    component: ResultComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }