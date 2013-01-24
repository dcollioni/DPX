rss.controller('RssController', function ($scope, $http) {
    $scope.items = [];
    function getItems() {
        $http({
            method: 'GET',
            url: "Rss/List"
        }).success(function (data) {
            $scope.items = data;
        });
    }
    getItems();
    setInterval(getItems, 30000);
});