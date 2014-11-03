angular.module('SinglePageApplication', [])
    .controller('MainController', [
        '$scope', "$http", function ($scope, $http) {
            $scope.readonlyMode = false;

            $http.get("api/repbook/1")
                .success(function (data) {
                    $scope.model = data;
                });
        }
    ]);
