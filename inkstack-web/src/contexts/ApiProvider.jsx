import { createContext, useContext } from "react";
import InkstackApiClient from "../InkstackApiClient";

const ApiContext = createContext();

export default function ApiProvider({children}) {
    const api = new InkstackApiClient();

    return (
        <ApiContext.Provider value={api}>
            {children}
        </ApiContext.Provider>
    );
}

export function useApi() {
    return useContext(ApiContext);
}