import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';


@Component({
  selector: 'app-root',
 
  
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class App implements OnInit{
  private http = inject(HttpClient);
  protected title = 'Dating App';
  protected members = signal<any>([])

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/members').subscribe({
      
      next: response => {
      console.log('Members loaded:', response);
      this.members.set(response);
    },
    error: err => {
      console.error('Error fetching members:', err);
    }
    });
  }

  
} 
