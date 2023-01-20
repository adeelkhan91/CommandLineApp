import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { ApiEndPoint } from '../shared/enums/api-end-points.enum';
import { Logs } from 'selenium-webdriver';
@Injectable({
  providedIn: 'root',
})
export class ApiService {
  apiMap = `${environment.geoAPI}`;

  constructor(private http: HttpClient) {}

//  headers = new Headers();
// headers.append('Content-Type', 'accept: text/plain');


// options = new RequestOptions({' Content-Type', 'accept: text/plain '});

httpOptions = {
  headers: new HttpHeaders({
    'Access-Control-Allow-Origin': '*',
  })
}

//  requestOptions = { headers: this.headers };
  /**
   * Get All the Countries List
   */
  getAllCountriesData(): Observable<any>
  {
    return this.http.get<any>(`${'/Country/allcountry'}`,this.httpOptions)
    .pipe(map((res)=>{
        // var data1 = JSON.parse(res);
      return res
    }));}
  // {
  //   return this.http.get<any>(`${this.apiCountries}${ApiEndPoint.ALL}`)
  //     .pipe(
  //       map((res) => {
  //         return res;
  //       })
  //     );
  // }

  /**
   * Get countries list based on region
   * @param region
   */
  getCountriesByRegion(region): Observable<any> {
    // return this.http.get<any>(`${this.apiCountries}${ApiEndPoint.REGION}/${region}`)
    return this.http.get<any>(`${'/Country/region'}/${region}`,this.httpOptions)
    .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on country name
   * @param name
   */
  getCountriesByName(name): Observable<any> {
    return this.http
      .get<any>(`${'/Country/name'}/${name}`,this.httpOptions)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on Country full Name
   * @param fullName
   */
  getCountriesByFullName(fullName): Observable<any> {
    return this.http
      .get<any>(
        `${'/Country/fname'}/${fullName}`,this.httpOptions)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on aplha code
   * @param code
   */
  getCountriesByCode(code): Observable<any> {
    return this.http
      .get<any>(`${'/Country/alpha'}/${code}`,this.httpOptions)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on currency
   * @param currency
   */
  getCountriesByCurrency(currency): Observable<any> {
    return this.http
      .get<any>(`${'/Country/currency'}/${currency}`)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on language codes
   * @param langCode
   */
  getCountriesByLanguage(langCode): Observable<any> {
    return this.http
      .get<any>(`${'/Country/language'}/${langCode}`)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on capital city
   * @param capitalCity
   */
  getCountriesbyCapital(capitalCity): Observable<any> {
    return this.http
      .get<any>(`${'/Country/capital'}/${capitalCity}`)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on calling code
   * @param callingcode
   */
  getCountriesByCallingCode(callingcode): Observable<any> {
    return this.http
      .get<any>(`${'/Country/callingcode'}/${callingcode}`)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get countries list based on regionalbloc
   * @param regionalBloc
   */
  getCountriesByRegionalbloc(regionalBloc): Observable<any> {
    return this.http
      .get<any>(
        `${"/Country/regionalbloc"}/${regionalBloc}`
      )
      .pipe(
        map((res) => {
          return res;
        })
      );
  }

  /**
   * Get Location based on IP Address
   * @param ipadress
   */
  getMapLocation(ipadress): Observable<any> {
    return this.http
      .get<any>(`${this.apiMap}&${ApiEndPoint.IPADDRESS}=${ipadress}`)
      .pipe(
        map((res) => {
          return res;
        })
      );
  }
      ;
  }

