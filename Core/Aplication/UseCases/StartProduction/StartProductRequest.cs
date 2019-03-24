using System;

namespace Core.Aplication.UseCases.StartProduction
{
    public class StartProductRequest
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime Now{ get; set; }
    }
}