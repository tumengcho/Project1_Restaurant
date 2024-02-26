import { Component, OnInit } from '@angular/core';
import * as Aos from 'aos';

@Component({
  selector: 'app-patisserie',
  templateUrl: './patisserie.component.html',
  styleUrls: ['./patisserie.component.css']
})
export class PatisserieComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    document.querySelector('.nav')?.classList.remove('affix')

    Aos.init({
      offset: 200,
      duration: 600,
      easing: 'ease-in-sine',
      delay: 100,
    })
  }

}
