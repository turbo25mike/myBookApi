using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Api.Data;
using Api.Model;

namespace Api.Api
{
    public class OrderController : ApiController
    {
        private MongoOrderDb _repo;

        public OrderController()
        {
            _repo = new MongoOrderDb();
        }
        public async Task<List<Order>> Get()
        {
            return await _repo.GetOrders();
        }

        public async Task<string> Post(Order order)
        {
            return await _repo.InsertOrder(order);
        }
    }
}
