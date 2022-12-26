import React from 'react';
import $ from 'jquery'
import './custom.css';

function test() {
    const p = {
        firstname: $("#fornavn").val(),
        lastname: $("#etternavn").val()
    };

    $.ajax({
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        'type': 'POST',
        'url': "https://localhost:7170/api/Home/lagre",
        'data': JSON.stringify(p),
        'dataType': 'json',

    })
    //https://skattjohan.azurewebsites.net/api/Home/lagre
}
function App() {
    return (
        <div>
            <label for="fornavn">Fornavn</label>
            <input type="text" id="fornavn"></input> <br />

            <label for="etternavn">Etternavn</label>
            <input type="text" id="etternavn"></input>
            <button onClick={test}></button>
            hei
            
        </div>
    )
}
export default App;