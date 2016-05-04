var app = angular.module('AngularAuthApp', ['ngRoute', 'LocalStorageModule']);

app.config(function ($locationProvider) {
        $locationProvider.html5Mode(true);
    });

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);