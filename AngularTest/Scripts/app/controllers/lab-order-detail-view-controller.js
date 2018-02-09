angular
    .module('myApp')
    .controller('labOrderDetailController',
        [
            '$scope', 'asyncDataService', 'apiEndpoints', '$location', '$state','$stateParams',
            function ($scope, asyncDataService, apiEndpoints, $location, $state, $stateParams) {

                var id = $stateParams.id;
                getLabOrderDetails(id);

                function getLabOrderDetails(id) {
                    //api endpoints defined in constants.js
                    var url = apiEndpoints.labOrderDetail + id;
                    asyncDataService.getDataFromUrl(url).then(function (data) {
                        $scope.labOrderDetails = data;
                        console.log($scope);
                    });
                }

                $scope.saveLabOrderDetails = function () {
                    var data = {
                        Id: $scope.labOrderDetails.id,
                        AmountCollected: $scope.labOrderDetails.amountCollected
                    };
                    var url = apiEndpoints.labOrderDetail;
                    asyncDataService.postDataToUrl(url, data).then(function(result) {
                        if (result && result.data === true) {
                            $state.go('main');   
                        } else {
                            console.log("An unexpected error has occurred.");
                        }
                    });
                }
            }
        ]);
