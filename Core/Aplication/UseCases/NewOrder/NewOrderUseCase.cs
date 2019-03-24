using System;
using System.Threading.Tasks;
using Core.Aplication.Repositories;
using Core.Domain.Order;

namespace Core.Aplication.UseCases.NewOrder
{
    public class NewOrderUseCase
    {
        private readonly NewOrderResponse _response;
        private readonly SahuarOSUnitOfWork _unitOfWork;
        private readonly NewOrderEventDistpacher _eventDistpacher;

        public NewOrderUseCase(SahuarOSUnitOfWork unitOfWork, NewOrderEventDistpacher eventDistpacher)
        {
            _eventDistpacher = eventDistpacher;
            _unitOfWork = unitOfWork;
            _response = new NewOrderResponse();
        }

        public async Task<NewOrderResponse> CreateOrder(NewOrderRequest request)
        {
            var customer = await _unitOfWork.CustomerRepository.FindAsync(request.CustomerId);
            var order = Order.Create(customer, request.Now);

            foreach (var orderProductRequest in request.Products)
            {
                var product = await _unitOfWork.ProductRepository.FindAsync(orderProductRequest.ProductId);
                var orderProduct = OrderProduct.Create(product, request.Now);
                orderProduct.IncreaseAmount(orderProductRequest.Amount);
                order.AddProduct(orderProduct);
            }

            try
            {
                _unitOfWork.OrderRepository.Attach(order);
                await _unitOfWork.SaveChangesAsync();
                _eventDistpacher.Distpach(order);
                _response.Success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _response.MessageError = e.Message;
            }

            return _response;
        }
    }
}