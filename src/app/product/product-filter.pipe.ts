import { Pipe, PipeTransform } from '@angular/core';

import { product } from './product';

@Pipe({
  name: 'productFilter'
})
export class ProductFilterPipe implements PipeTransform {

  transform(value: product[], filtertext: any): product[] {
    filtertext = filtertext?filtertext.toLocaleLowerCase():null

    return filtertext?value.filter ((p:product)=>p.name.toLocaleLowerCase().indexOf(filtertext)!==-1):value;
  }

}
