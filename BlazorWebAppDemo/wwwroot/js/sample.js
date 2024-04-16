function callMethod() {
    DotNet.invokeMethodAsync("BlazorWebAppDemo", "GetValueFromMethod").then(result => {
        alert('Message from Method : ' + result);
    });
}

function callInstanceMethod(instanceObject) {
    instanceObject.invokeMethodAsync("GetValueFromInstance").then(result => {
        alert('Message from Method : ' + result);
    });
}