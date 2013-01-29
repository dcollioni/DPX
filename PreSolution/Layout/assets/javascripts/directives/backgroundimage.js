dpx.directive('ngBackgroundImage', function(){
    return function(scope, element, attributes){
        attributes.$observe('ngBackgroundImage', function(value) {
            element.css({
                'background-image': 'url(' + value +')',
                'background-size' : 'cover'
            });
        });
    };
});