import { Component } from '@angular/core';
import { LoginComponent } from './login/login';  // ✅ your path may vary

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [LoginComponent],
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class App {
  protected title = 'Loginpage';
}
