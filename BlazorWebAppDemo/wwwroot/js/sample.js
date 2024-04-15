function callMethod() {
    DotNet.invokeMethodAsync("BlazorWebAppDemo", "GetValueFromMethod").then(result => {
        alert('Message from Method : ' + result);
    });
}