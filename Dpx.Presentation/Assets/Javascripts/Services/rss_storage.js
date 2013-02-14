rss.factory('rssStorage', function ($http) {
    return {
        get: function () {
            $http.get('Rss/Index').success(function (data) {
                //$scope.items = data;
            });
        }
    };
});
