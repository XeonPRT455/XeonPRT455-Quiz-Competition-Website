import { Component, OnInit } from '@angular/core';
import { UserServiceService } from '../services/user-service.service';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {
  quiz$: Object;
  a$: Object;

  constructor(private data: UserServiceService) { }




  ngOnInit() {
    this.data.getQuiz().subscribe(
      data => this.quiz$ = data
    );
  }

}
