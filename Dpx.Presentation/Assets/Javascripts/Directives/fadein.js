dpx.directive('dpxFadeIn', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attribs) {
            scope.$watch(attribs.dpxFadeIn, function (value) {
                if (value) {
                    $(element[0]).fadeIn();
                } else {
                    $(element[0]).hide();
                }
            });
        }
    };
});