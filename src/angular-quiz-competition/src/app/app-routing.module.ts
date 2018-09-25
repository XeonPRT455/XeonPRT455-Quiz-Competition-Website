import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';
import{ RouterModule, Routes} from '@angular/router';
import { UserInfoComponent} from './components/user-info/user-info.component';

const routes: Routes = [
  { path: '', redirectTo:'/userInfo', pathMatch: 'full'},
  //{path:'', component: UserInfoComponent},
  {path:'userInfo', component: UserInfoComponent}
]
@NgModule({
  
  imports: [
   // CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }
