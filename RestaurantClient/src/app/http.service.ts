import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {lastValueFrom} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class HttpService {


  PlatList: PlatDTO[] = [];
  constructor(public http: HttpClient) { }


  async CreateReservation(nomnbre: number, nom:string, date:Date, email:string){
    let r = new ReservationDTO(nomnbre,nom,date,email);
let result = await lastValueFrom(this.http.post<any>('http://localhost:5095/api/Reservations',r))
    console.log(result)
  }
async getFood(){
  let result = await lastValueFrom(this.http.get<PlatDTO[]>('http://localhost:5095/api/platsGet'))
  console.log(result);
  this.PlatList = result;

}


}

export class ReservationDTO{
  constructor(public NbreClient:number, public NomDuReservateur:string, public DateTime: Date, public email: string) {
  }
}
export class PlatDTO{
  public name: string| any;
  public prix: number| any;
  public images: string| any;

}
