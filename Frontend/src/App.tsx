import React, { useEffect, useState } from "react";

export default function App() {
    const [message, setMessage] = useState("Loading...");

    useEffect(() => {
        fetch("/api/hello-world")
            .then(response => response.text())
            .then(text => setMessage(text))
            .catch(error => setMessage(error));
    }, []);

    return (
        <h1>{message}</h1>
    );
}