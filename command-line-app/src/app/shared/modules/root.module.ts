import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RootRoutingModule } from './root-routing.module';
import { SharedLibModule } from './shared-lib.module';

import { SidebarComponent } from 'src/app/components/sidebar/sidebar.component';
import { HeaderComponent } from 'src/app/components/header/header.component';
import { ConfirmDialogComponent } from 'src/app/components/header/confirm-dialog/confirm-dialog.component';
import { CountriesListComponent } from 'src/app/components/countries-list/countries-list.component';
import { SelectedCountryDataComponent } from 'src/app/components/selected-country-data/selected-country-data.component';
import { IpAddressTrackerComponent } from 'src/app/components/ip-address-tracker/ip-address-tracker.component';
import { NgxSpinnerComonent } from 'src/app/components/spinner/ngx-spinner';

import { FilterPipe } from '../pipes/filter.pipe';
import { ComaSeperatorPipe } from '../pipes/coma-seperator.pipe';

@NgModule({
  declarations: [
    SidebarComponent,
    HeaderComponent,
    ConfirmDialogComponent,
    CountriesListComponent,
    SelectedCountryDataComponent,
    IpAddressTrackerComponent,
    NgxSpinnerComonent,
    FilterPipe,
    ComaSeperatorPipe,
  ],
  imports: [CommonModule, RootRoutingModule, SharedLibModule],
  providers: [],
})
export class RootModule {}
