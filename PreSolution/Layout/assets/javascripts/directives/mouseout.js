dpx.directive('dpxMouseout', function() {
    return function(scope, element, attributes) {
        element.bind('mouseout', function() {
            scope.$apply(attributes.dpxMouseout);
        });
    };
});
