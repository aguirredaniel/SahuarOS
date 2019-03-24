var OrderPresenter = (function (data) {
    "use strict";
    var _orderStatus = {
        0: {
            name: "Recibida",
            color: "btn-info"
        },
        1: {
            name: "Empezda",
            color: "btn-warning"
        },
        2: {
            name: "Terminada",
            color: "btn-success"
        }
    }
    var self = {
        present: present
    };

    function present(order) {
        var products = [];
        order.products.forEach(function (p) {
            products.push(presentProduct(p))
        });

        return {
            id: order.id,
            creatAt: order.creatAt.fromNow(),
            progress: order.progress + "%",
            status: _orderStatus[order.status],
            products: products,
            customer: order.customer,
            view: "",
            edit: ""
        }
    }

    function presentProduct(product) {
        return {
            image: "/Product/Image/" + product.id,
            name: product.name
        }
    }

    return self;
});