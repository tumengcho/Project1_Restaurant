import { Component, OnInit } from '@angular/core';
import * as Aos from 'aos';
import {HttpService} from "../http.service";

@Component({
  selector: 'app-patisserie',
  templateUrl: './patisserie.component.html',
  styleUrls: ['./patisserie.component.css']
})
export class PatisserieComponent implements OnInit {

  constructor(public Http: HttpService) { }

  ngOnInit() {
    this.Http.getFood();
    document.querySelector('.nav')?.classList.remove('affix')

    Aos.init({
      offset: 200,
      duration: 600,
      easing: 'ease-in-sine',
      delay: 100,
    })
  }

}
