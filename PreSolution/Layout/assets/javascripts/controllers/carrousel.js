dpx.controller('CarrouselController', function($scope){
    $scope.items = [
        { title: 'DPX',      src: 'assets/images/first.jpg',  selected: true, nextIndex: 1 },
        { title: 'Empresa',  src: 'assets/images/second.jpg', selected: false, nextIndex: 2 },
        { title: 'Serviços', src: 'assets/images/third.jpg',  selected: false, nextIndex: 3 },
        { title: 'Clientes', src: 'assets/images/fourth.jpg', selected: false, nextIndex: 4 },
        { title: 'Contato',  src: 'assets/images/fifth.jpg',  selected: false, nextIndex: 0 }
    ];

    $scope.getSelected = function(){
        return $scope.items.filter(function(item){ return item.selected; })[0];
    };

    $scope.select = function(clickedItem){
        $scope.getSelected().selected = false;
        clickedItem.selected = true;
    };

    $scope.next = function(){
        $scope.select($scope.items[$scope.getSelected().nextIndex]);
        $scope.$apply();
    };

    $scope.turnOn = function(){
        $scope.turnOff();
        $scope.intervalId = setInterval($scope.next, 3000);
    }

    $scope.turnOff = function(){
        clearInterval($scope.intervalId);
    }

    $scope.showSocial = function(){
        return $scope.items[0].selected;
    };

    $scope.networks = [
        { href: 'http://facebook.com', src: 'assets/images/facebook.png', alt: 'Facebook' },
        { href: 'http://twitter.com', src: 'assets/images/twitter.png', alt: 'Twitter' },
        { href: 'http://linkedin.com', src: 'assets/images/linkedin.png', alt: 'LinkedIn' },
        { href: 'http://plus.google.com', src: 'assets/images/googleplus.png', alt: 'Google+' }
    ]

    $scope.turnOn();
});