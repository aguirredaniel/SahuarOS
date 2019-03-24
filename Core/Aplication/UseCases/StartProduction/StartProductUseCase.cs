using System;
using System.Threading.Tasks;
using Core.Aplication.Repositories;

namespace Core.Aplication.UseCases.StartProduction
{
    public class StartProductoUseCase
    {
        private readonly SahuarOSUnitOfWork _unitOfWork;

        public StartProductoUseCase(SahuarOSUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<StartProductoResponse> Start(StartProductRequest request)
        {
            var order = await _unitOfWork.OrderRepository.FindAsync(request.OrderId);
            var gCode = order.StarProduct(request.ProductId, request.Now);
            try
            {
                _unitOfWork.OrderRepository.Update(order);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return new StartProductoResponse();
            }

            return new StartProductoResponse(){GCode = gCode};
        }
    }
}