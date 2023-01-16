import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CountriesListComponent } from 'src/app/components/countries-list/countries-list.component';
import { SelectedCountryDataComponent } from 'src/app/components/selected-country-data/selected-country-data.component';
import { IpAddressTrackerComponent } from 'src/app/components/ip-address-tracker/ip-address-tracker.component';

import { AuthGuardGuard } from '../auth-guard.guard';

import { Path } from '../enums/route-path.enum';

const routes: Routes = [
  {
    path: '',
    children: [
      { path: '', redirectTo: Path.ALLCOUNTRIES, pathMatch: 'full' },
      {
        path: Path.ALLCOUNTRIES,

        component: CountriesListComponent,
      },
      {
        path: Path.COUNTRY,
        component: SelectedCountryDataComponent,
      },
      { path: Path.IPADDRESS, component: IpAddressTrackerComponent },

      { path: Path.WILDCARD, redirectTo: Path.PAGENOTFOUND },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class RootRoutingModule {}
