const BASE_API_URL = import.meta.env.VITE_REACT_APP_BASE_API_URL;

export default class InkstackApiClient {

    constructor() {
        this.baseUrl = BASE_API_URL + '/api';
    }

    async request(path) {
        
        let response;
        try {
            response = await fetch(this.baseUrl + path, {
                method: 'GET',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: null
            });
        } catch (error) {
            response = {
                status: 500
            };
        }

        return response;
    }
}