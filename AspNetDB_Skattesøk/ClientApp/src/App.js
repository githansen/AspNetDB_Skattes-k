import React from 'react';
import $ from 'jquery'
import './custom.css';

function test() {
    $.get("https://skattjohan.azurewebsites.net/api/Home/retur", function (data) {
        console.log(data)
        console.log("AZURE")
    })
    
    $.get("https://localhost:7170/api/Home/retur", function (data) {
        console.log(data);
        console.log("PC")
    })
}
function App() {
    return (
        <div>
            hei
            <button onClick={test }>Test</button>
            <div id="ut"></div>
        </div>
    )
}
export default App;