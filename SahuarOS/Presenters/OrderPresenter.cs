using System;
using Core.Domain.Order;

namespace SahuarOS.Presenters
{
    public class OrderPresenter
    {
        public static string PresenetStatus(Order.OrderStatus status)
        {
            switch(status){
                case Order.OrderStatus.Received:
                    return "Recibida";
                case Order.OrderStatus.Started:
                    return "Empezada";
                case Order.OrderStatus.Finished:
                    return "Terminda";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        public static string PresentStatus(OrderProduct.OrderProductStatus status)
        {
            switch (status)
            {
                case OrderProduct.OrderProductStatus.Received:
                    return "Recibido";
                case OrderProduct.OrderProductStatus.Started:
                    return "Imprimiendo";
                case OrderProduct.OrderProductStatus.Finished:
                    return "Terminado";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }


    }
}