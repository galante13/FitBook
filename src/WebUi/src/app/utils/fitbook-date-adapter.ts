import { NativeDateAdapter } from '@angular/material';

export class FitbookDateAdapter extends NativeDateAdapter {

    format(date: Date, displayFormat: Object): string {
        const day = date.getDate();
        const month = date.getMonth() + 1;
        const year = date.getFullYear();
        return `${day}/${month}/${year}`;
    }
}
