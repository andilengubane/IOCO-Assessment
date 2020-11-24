import { Injectable } from '@angular/core';
import { Pet } from '../pet/pet';
import { HttpClient, HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  constructor(private http: HttpClient) { }

  postPet(petModel:Pet){
    var httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    }
    return this.http.post('http://localhost:59081/api/Owner/SaveOwner',
                    JSON.stringify(petModel), 
                    httpOptions);
  }
}
