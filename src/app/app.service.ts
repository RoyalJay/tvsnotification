import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Rx';

// for RxJs required methods
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class AppService {
    private tvShowUrl = 'api/TvShow';

    // resolve http using ctor
    constructor(private _http: Http) { }

    getTvShows(): Observable<any> {
        return this._http.get(this.tvShowUrl).map((response: Response) =>  {
            return response.text();
        });
    }
}