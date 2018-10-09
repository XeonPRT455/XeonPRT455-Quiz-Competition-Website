import { Component, OnInit } from '@angular/core';
import {QuizComponent} from '../quiz/quiz.component';
import { from } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { UserServiceService } from '../services/user-service.service';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-answer',
  templateUrl: './answer.component.html',
  styleUrls: ['./answer.component.css']
})
export class AnswerComponent implements OnInit {
answer$: Object;
constructor(private route: ActivatedRoute, private data: UserServiceService) {
  this.route.params.subscribe( params => this.answer$ = params.id );
}
  ngOnInit() {
    this.data.getQuiz().subscribe(
      data => this.answer$ = data
    );
  }

}
