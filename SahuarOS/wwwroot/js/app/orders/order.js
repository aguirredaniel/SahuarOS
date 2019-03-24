var Order = (function (data) {
    "use strict";
    var self = {
        id: data.id,
        creatAt: moment(data.creatAt),
        customer: data.customer,
        products: data.products,
        progress: data.progress,
        status: data.status,
    };
    
    return self;
});