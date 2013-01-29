dpx.controller('CarrouselController', function($scope){
    $scope.items = [
        { title: 'DPX',      src: 'assets/images/first.jpg',  selected: true },
        { title: 'Empresa',  src: 'assets/images/second.jpg', selected: false },
        { title: 'Serviços', src: 'assets/images/third.jpg',  selected: false },
        { title: 'Clientes', src: 'assets/images/fourth.jpg', selected: false },
        { title: 'Contato',  src: 'assets/images/fifth.jpg',  selected: false }
    ];

    $scope.select = function(clickedItem){
        $scope.items.forEach(function(item) { item.selected = false; });
        clickedItem.selected = true;
    };
});