import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http'; 
  

@Component({
  selector: 'app-list-owner',
  templateUrl: './list-owner.component.html',
  styleUrls: ['./list-owner.component.css']
})
export class ListOwnerComponent implements OnInit {
  constructor(private httpService: HttpClient) { }
  owner : string[];

  ngOnInit(): void {
    this.httpService.get('http://localhost:52202/api/OwnerPet/GetOwnerPetList').subscribe(  
      data => {  
       this.owner = data as string [];  
      }  
    );
  }
}
