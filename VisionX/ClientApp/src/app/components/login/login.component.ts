import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import ValidateForm from 'src/app/helpers/validateform';

@Component({
selector: 'login-component',
templateUrl: './login.component.html',
styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

type : string = "password";
isText : boolean = false;
eyeIcon : string = "fa-eye-slash";

loginForm!: FormGroup;
constructor(private fb : FormBuilder) {
}

ngOnInit(){
    this.loginForm = this.fb.group({
     username :['', Validators.required],
     password :['', Validators.required]      
    });
}

hideshowpass(){
    this.isText = !this.isText;
    this.isText ? this.eyeIcon = "fa-eye" : this.eyeIcon ="fa-eye-slash";
    this.isText ? this.type = "text" : this.type = "password";
   }

onSubmit(){
  if (this.loginForm.valid){
      // send object to API 
      console.log(this.loginForm.value);
  }else{
    console.log('Form is not valid');
    ValidateForm.validateAllFormFields(this.loginForm);
    alert("Your form is invalid");
     // throw toaster and with required fields 
  }
}


}