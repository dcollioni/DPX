dpx.directive('ngMouseout', function() {
    return function(scope, element, attributes) {
        element.bind('mouseout', function() {
            scope.$apply(attributes.ngMouseout);
        });
    };
});
