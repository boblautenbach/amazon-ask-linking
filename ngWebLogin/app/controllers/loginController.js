'use strict';
app.controller('loginController', ['$window', '$scope', '$location', 'authService', function ($window,  $scope, $location, authService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.message = "";

    $scope.login = function () {

        var scope = $location.search()['scope'];
        var response_type = $location.search()['response_type'];
        var state = $location.search()['state'];
        var client_id = $location.search()['client_id'];

        var amazonRedirectrl = 'http://localhost:63026/mockAmazonRedirect.html?vender=aaaaaa#';

        authService.login($scope.loginData, client_id).then(function (response) {

            var redirectQS = "state=" + state + "&access_token=" + response.access_token + "&token_type=Bearer";

            $window.location.href = amazonRedirectrl + redirectQS;
        },
         function (err) {
             $scope.message = err.error_description;
         });
    };

}]);