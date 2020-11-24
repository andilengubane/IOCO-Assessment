import { Component, OnInit } from '@angular/core';
import { Owner } from './owner';
import { FormBuilder } from '@angular/forms';
import { OwnerService } from './owner.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-owner',
  templateUrl: './owner.component.html',
  styleUrls: ['./owner.component.css'],
  providers:[OwnerService]
})

export class OwnerComponent implements OnInit {
  
  formGroup;
  ngOnInit(): void {
    this.service.petList();
  }

  constructor(private formBuilder: FormBuilder,
              public service : OwnerService,
              private toastrNotification: ToastrService
              ) { 
            this.formGroup = this.formBuilder.group({
            firstname : '',
            lastname : '',
            phonenumber : '',
            idnumber : '',
            address : ''
          });
  }

  onSubmit(formGroup){
    this.service.postOwner(formGroup).subscribe();
    this.toastrNotification.success('owner', 'owner added successful');
  }
}
