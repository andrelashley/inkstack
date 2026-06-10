import { useState } from "react";
import InputField from "../components/InputField";

export default function LoginPage() {
    const [formErrors, setFormErrors] = useState({});
    
    const onSubmit = (ev) => {
        ev.preventDefault();
        console.log('handle form here');
    };

    return (
        <>
            <h1>Login</h1>
            <form onSubmit={onSubmit}>
                <InputField />
            </form>
        </>
    );
}