import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { TradingviewEmbedComponent } from './components/tradingview/tradingview-embed.component';

const routes: Routes = [
  {path :'', redirectTo : 'login', pathMatch:'prefix'},
  {path :'login', component:LoginComponent},
  { path: 'signup', component: SignupComponent },
  { path: 'home', component: TradingviewEmbedComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
