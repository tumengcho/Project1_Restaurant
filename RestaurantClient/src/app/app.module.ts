import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from "@angular/common/http";
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { PatisserieComponent } from './patisserie/patisserie.component';
import { ReservationComponent } from './reservation/reservation.component';
import { FormsModule } from '@angular/forms';
import { ContactComponent } from './contact/contact.component';
import { AboutComponent } from './about/about.component';

@NgModule({
  declarations: [			
    AppComponent,
      HomeComponent,
      PatisserieComponent,
      ReservationComponent
   ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule,
    RouterModule.forRoot([
      {path:"", redirectTo:"/home", pathMatch:"full"},
      {path:"home", component: HomeComponent},
      {path:"patisserie", component: PatisserieComponent},
      {path:"reservation", component: ReservationComponent},
      {path:"contact", component: ContactComponent},
      {path:"about", component: AboutComponent}


    ]
    ),
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
