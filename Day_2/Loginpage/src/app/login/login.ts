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
    if (this.email === 'admin@example.com' && this.password === 'admin123') {
      alert('Login successful!');
    } else {
      alert('Invalid credentials');
    }
  }
}
