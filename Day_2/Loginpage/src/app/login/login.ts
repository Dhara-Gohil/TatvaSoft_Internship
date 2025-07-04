import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './login.html',
  styleUrls: ['./login.css']
})
export class LoginComponent {
  email: string = '';
  password: string = '';

  onLogin() {
    if (this.email === 'dharagohil@gmail.com' && this.password === 'dhara123') {
      alert('Login successful!');
      console.log("Hello Dhara");
    } else {
      alert('Invalid credentials');
    }
  }
}
