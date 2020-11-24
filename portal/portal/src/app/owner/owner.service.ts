import { Injectable } from '@angular/core';
import { Owner } from './owner';
import { Pet } from '../pet/pet';
import { HttpClient, HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OwnerService {

  OwnerModel: Owner;
  OwnerListModel : Owner[];
  readonly url = 'http://localhost:59081/api/Pet/';  
  listPets : Pet[]; 

  constructor(private http: HttpClient) { }

  petList() {  
    return this.http.get(this.url + 'GetPets').toPromise().then(result=>this.listPets = result as Pet[])
  } 

  postOwner(OwnerModel:Owner){
    var httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    }
    return this.http.post('http://localhost:59081/api/Owner/SaveOwner',
                    JSON.stringify(OwnerModel), 
                    httpOptions);
  }
}
