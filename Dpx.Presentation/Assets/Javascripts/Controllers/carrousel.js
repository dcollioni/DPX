dpx.controller('CarrouselController', function($scope){
    $scope.test = "this is a test";

    $scope.items = [
        { title: 'DPX',      class: 'first',  selected: true,  nextIndex: 1 },
        { title: 'Empresa',  class: 'second', selected: false, nextIndex: 2 },
        { title: 'Serviços', class: 'third',  selected: false, nextIndex: 3 },
        { title: 'Clientes', class: 'fourth', selected: false, nextIndex: 4 },
        { title: 'Contato',  class: 'fifth',  selected: false, nextIndex: 0 }
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
        $scope.intervalId = setInterval($scope.next, 5000);
    };

    $scope.turnOff = function(){
        clearInterval($scope.intervalId);
    };

    $scope.turnOn();
});