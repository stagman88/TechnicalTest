import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'sort'
})
export class SortPipe implements PipeTransform {

  transform(value: any[], args: any): any {
    const sortField = args[0];
    const sortDirection = args[1];
    let mulitplier = 1;

    if (sortDirection === 'desc') {
      mulitplier = -1;
    }

    value.sort((a: any, b: any) => {
      if (a[sortField] < b[sortField]) {
        return -1 * mulitplier;
      } else if (a[sortField] > b[sortField]) {
        return 1 * mulitplier;
      } else {
        return 0;
      }
    });

    return value;
  }

}
