import { CommonModule } from '@angular/common';
import { Component, signal } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { CreateComponent } from './components/create/create.component';
import { ListComponent } from './components/list/list.component';

@Component({
  selector: 'app-shopping-list',
  standalone: true,
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css'],
  imports: [
    CommonModule,
    RouterLink,
    RouterLinkActive,
    RouterOutlet,
    ListComponent,
    CreateComponent,
  ],
})
export class ShoppingListComponent {
  shoppingList = signal([
    { id: '1', description: 'Shampoo', purchased: false },
    { id: '2', description: 'Lettuce', purchased: true },
  ]);
}
