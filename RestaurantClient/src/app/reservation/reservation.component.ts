import { Component, OnInit } from '@angular/core';
import {HttpService} from "../http.service";

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.css']
})
export class ReservationComponent implements OnInit {

  constructor(public Serv:HttpService) { }
  confirm: boolean = false;
  nom:string|any
  nombre:number|any
  date:Date|any
  email:string|any


  ngOnInit() {
    this.Serv.getFood();
  }
 async create(){
await this.Serv.CreateReservation(this.nombre,this.nom,this.date,this.email);
this.confirm = true;
 }

}
