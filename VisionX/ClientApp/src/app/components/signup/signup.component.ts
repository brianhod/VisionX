import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import ValidateForm from 'src/app/helpers/validateform';

@Component({
selector: 'signup-component',
templateUrl: './signup.component.html',
styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

type : string = "password";
isText : boolean = false;
eyeIcon : string = "fa-eye-slash";
signUpForm! : FormGroup;

constructor(private  fb : FormBuilder) {
}

ngOnInit(){
 this.signUpForm = this.fb.group({
  firstName : ['', Validators.required],
   lastName : ['', Validators.required],
   userName : ['', Validators.required],
   email : ['', Validators.required],
   password : ['', Validators.required],
 })
}

hideshowpass(){
    this.isText = !this.isText;
    this.isText ? this.eyeIcon = "fa-eye" : this.eyeIcon ="fa-eye-slash";
    this.isText ? this.type = "text" : this.type = "password";
   }

  onSignUp() {
     if(this.signUpForm.valid){
         // perform logic for signup
     } else{
        ValidateForm.validateAllFormFields(this.signUpForm);
         // logic for throwing error
     }
  } 
}