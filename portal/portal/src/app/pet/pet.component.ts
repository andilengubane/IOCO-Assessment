import { Component, OnInit } from '@angular/core';
import { PetService } from './pet.service';
import { FormBuilder,Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-pet',
  templateUrl: './pet.component.html',
  styleUrls: ['./pet.component.css']
})
export class PetComponent implements OnInit {

     formGroup;
     constructor(private formBuilder: FormBuilder,
          public service : PetService,
          private toastrNotification: ToastrService
          ) { 
         
    };
    ngOnInit(): void {
     this.formGroup = this.formBuilder.group({
          name : [null, [Validators.required]],
          description : [null, [Validators.required]],
    });
}  

     onSubmit(formGroup){
        this.service.postPet(formGroup).subscribe();
        this.toastrNotification.success('pet', 'pet added successful');
     }
}
