import { createActionGroup, props } from '@ngrx/store';
import { ShoppingListEntity } from './list.reducer';

type ShoppingListEntityCreateModel = Pick<ShoppingListEntity, 'description'>;
export const ListEvents = createActionGroup({
  source: 'Shopping List Events',
  events: {
    'Item Added': props<{ payload: ShoppingListEntityCreateModel }>(),
  },
});

export const ListDocuments = createActionGroup({
  source: 'Shopping List Documents',
  events: {
    list: props<{ payload: ShoppingListEntity[] }>(),
    item: props<{ payload: ShoppingListEntity }>(),
  },
});
