angular.module('restMan', ['ngRoute'])
    //.value('fbURL', 'https://angularjs-projects.firebaseio.com/')
    //.factory('Projects', function($firebase, fbURL) {
    //    return $firebase(new Firebase(fbURL));
    //})
    .config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'DashboardCtrl',
                templateUrl: '/Dashboard/Details'
            })
            .when('/Menu', {
                controller: 'MenuCtrl',
                templateUrl: 'Menu'
            })
            .when('/Restaurant', {
                controller: 'RestaurantCtrl',
                templateUrl:'Restaurant'
            })
            .otherwise({
                redirectTo: '/'
            });
    })
    .controller('DashboardCtrl', function ($scope, $http) {
        $scope.tmp = "test1";

        $http.get('/api/dashboard').success(function (data) {
            $scope.vals = data;
        });
    })
    .controller('RestaurantCtrl', function ($scope, $http) {
        $scope.tmp = "test1";

    })
    .controller('MenuCtrl', function ($scope, $http) {
        $scope.tmp = "test1";

    });