var OrderHub = (function () {
    "use strict";
    var connection = new signalR.HubConnectionBuilder()
        .withUrl("/orderHub")
        .build();

    var _subscriber = {};

    function init(subscriber) {
        _subscriber = subscriber;
        connection.start().catch(function (err) {
            return console.error(err.toString());
        });

    }

    connection.on("newOrder", function (data) {
        if (!anySubcriber()) return;
        _subscriber.onNewOrder(data);
    });

    function anySubcriber() {
        return _subscriber !== null;
    }

    return {
        init: init,
    }
});


