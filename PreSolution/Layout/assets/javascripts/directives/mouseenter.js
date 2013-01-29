dpx.directive('ngMouseenter', function() {
    return function(scope, element, attributes) {
        element.bind('mouseenter', function() {
            scope.$apply(attributes.dpxHover);
        });
    };
});
