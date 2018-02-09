angular
    .module('myApp')
    .controller('labOrderListViewController',
        [
            '$scope', 'asyncDataService', 'apiEndpoints', '$location','$state',
            function ($scope, asyncDataService, apiEndpoints, $location, $state) {

                $scope.showDetails = false;

                function loadData() {
                    //api endpoints defined in constants.js
                    var url = apiEndpoints.labOrderList;
                    asyncDataService.getDataFromUrl(url).then(function (data) {
                        $scope.labOrders = data;
                        console.log($scope);
                    });
                }
                loadData();
                $scope.showLabOrderDetails = function(id) {
                    if (id && !id.isNaN) {
                        $state.go('details', { id: id });
                    }
                };
            }
        ]);
