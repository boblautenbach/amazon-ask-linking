﻿'use strict';
app.factory('authService', ['$http', '$q', 'localStorageService', function ($http, $q, localStorageService) {

    var serviceBase = 'http://localhost:61059/';
    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        userName: ""
    };


    var _login = function (loginData, client_id, client_secret) {

        var postData = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password + "&client_id=" + client_id + "&client_secret=" + client_secret;

        var deferred = $q.defer();

        $http({
            method: 'POST',
            url: serviceBase,
            data: postData,
            headers: {'Content-Type': 'application/x-www-form-urlencoded' }
        }).success(function (response) {

            localStorageService.set('authorizationData', { token: response.access_token, userName: loginData.userName });

            _authentication.isAuth = true;
            _authentication.userName = loginData.userName;

            deferred.resolve(response);

        }).error(function (err, status, headers, config) {
            deferred.reject(err);
        });

        return deferred.promise;

    };

    var _fillAuthData = function () {

        var authData = localStorageService.get('authorizationData');
        if (authData) {
            _authentication.isAuth = true;
            _authentication.userName = authData.userName;
        }

    }

    authServiceFactory.login = _login;
    authServiceFactory.fillAuthData = _fillAuthData;
    authServiceFactory.authentication = _authentication;

    return authServiceFactory;
}]);