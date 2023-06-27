import { Component, signal } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-counter',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css'],
})
export class CounterComponent {
  current = signal(0);

  increment() {
    this.current.set(this.current() + 1);
  }
  decrement() {
    this.current.set(this.current() - 1);
  }
}
