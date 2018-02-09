angular.module('myApp').config([
    '$stateProvider','$locationProvider', '$mdIconProvider', '$urlRouterProvider', '$mdThemingProvider',
    function ($stateProvider, $locationProvider, $mdIconProvider, $urlRouterProvider, $mdThemingProvider) {

        $locationProvider.hashPrefix('');
        // theme
        $mdThemingProvider.theme('default')
            .primaryPalette('blue')
            .accentPalette('light-green')
            .foregroundPalette['1'] = 'rgb(5, 57, 72)';

        // routes
        $urlRouterProvider.otherwise('/main');
        $stateProvider.state('main',
            {
                url: '/main',
                templateUrl: '/scripts/app/views/main.html',
                controller: 'mainController'
            }).state('details',
            {
                url: '/detail/:id',
                templateUrl: '/scripts/app/directives/templates/lab-order-detail-view-control.html',
                controller: 'labOrderDetailController'
            });
    }
]);