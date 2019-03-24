var ProductionPresenter = (function (data) {
    "use strict";
    var orderStatus = {
        0: {
            name: "Recibida",
            color: "btn-info"
        },
        1: {
            name: "Empezada",
            color: "btn-warning"
        },
        2: {
            name: "Terminada",
            color: "btn-success"
        }
    }
    var productStatus = {
        0: {
            id: 0,
            name: "Recibido",
            color: "btn-info"
        },
        1: {
            id: 1,
            name: "Imprimiendo",
            color: "btn-warning"
        },
        2: {
            id: 2,
            name: "Termindo",
            color: "btn-success"
        }
    }
    var self = {
        present: present,
        presentStatus: presentStatus
    };

    function presentStatus(status) {
        return orderStatus[status];
    }

    function present(order) {
        var products = [];
        order.products.forEach(function (p) {
            products.push(presentProduct(p))
        });

        return {
            id: order.id,
            creatAt: order.creatAt.fromNow(),
            progress: order.progress + "%",
            status: orderStatus[order.status],
            products: products,
            customer: order.customer,
            view: "",
            edit: ""
        }
    }

    function presentProduct(product) {
        return {
            id: product.id,
            amount: product.amount,
            image: "/Product/Image/" + product.id,
            name: product.name,
            sku: product.sku,
            description: product.description,
            status: productStatus[product.status]
        }
    }

    return self;
});