const BASE_API_URL = import.meta.env.VITE_REACT_APP_BASE_API_URL;

export default class InkstackApiClient {

    constructor() {
        this.baseUrl = BASE_API_URL + '/api';
    }

    async request(options) {
        let query = new URLSearchParams(options.query || {}).toString();
        if(query !== '') {
            query = '?' + query;
        }

        let response;
        try {
            response = await fetch(this.baseUrl + options.url + query, {
                method: options.method,
                headers: {
                    'Content-Type': 'application/json',
                    ...options.headers,
                },
                body: options.body ? JSON.stringify(options.body) : null,
            });
        } catch (error) {
            response = {
                ok: false,
                status: 500
            };
        }

        return response;
    }

    async get(url, query, options) {
        return this.request({method: 'GET', url, query, ...options});
    }

    // async post(url, body, options) {
    //     return this.request({method: 'POST', url, body, ...options});
    // }

}