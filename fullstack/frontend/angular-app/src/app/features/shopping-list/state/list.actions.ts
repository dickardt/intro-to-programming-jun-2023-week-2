import { createActionGroup, props } from '@ngrx/store';
import { ShoppingListEntity } from './list.reducer';

export const ListDocuments = createActionGroup({
  source: 'Shopping List Documents',
  events: {
    list: props<{ payload: ShoppingListEntity[] }>(),
  },
});
