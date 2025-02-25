import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { CreateComponent } from './components/create/create.component';
import { ListComponent } from './components/list/list.component';

import { Store } from '@ngrx/store';
import { ShoppingFeatureEvents } from './state/feature.actions';

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
  constructor(private store: Store) {
    store.dispatch(ShoppingFeatureEvents.entered());
  }
}
