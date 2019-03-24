(function (angular) {
    "use strict";

    angular.module('orderApp')
        .controller('OrderController', OrderController);

    OrderController.$inject = [
        '$scope',
        'OrderContext'];

    function OrderController($scope, context) {
        var presenter = OrderPresenter();
        var hub = OrderHub();
        var self = {orders: []};

        context.orders.forEach(function (o) {
            self.orders.push(presenter.present(Order(o)));
        });


        function init() {
            hub.init({onNewOrder: onNewOrder});
        }

        init();

        function onNewOrder(order) {
            self.orders.unshift(presenter.present(Order(order)));
            $scope.$apply();
        }


        return self;
    }
})(angular);