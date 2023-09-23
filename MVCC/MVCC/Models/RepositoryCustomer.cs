using Microsoft.EntityFrameworkCore;

namespace MVCC.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthWindContext _context;
        public RepositoryCustomer(NorthWindContext context)
        {
            _context = context;
        }
        //public List<Order> AllOrders()
        //{
        //    return _context.Orders.ToList();
        //}
       
        
        public List<string> GetAllCustomerId()
        {
            return _context.Customers.Select(customer => customer.CustomerId).ToList();
        }
        public Customer FindCustomerById(string id)
        {
            return _context.Customers.FirstOrDefault(customer => customer.CustomerId == id);
        }
        //public List<Customer> FindCustomerByCustomerID(string customerID)
        //{
        //    return _context.Customer.Where(customer => customer.CustomerId == customerID).ToList();
        //}
        //public List<Customer> FindCustomerDetailByCustomerId(int id)
        //{
        //    List<Customer> customerssWithCustomerDetails = _context.Customers.Include(d => d.CustomerDetails).ToList();
        //    Order order = customersWithCustomerDetails.FirstOrDefault(x => x.CustomerId == id);

        //    return customer.CustomerDetails.ToList();
        //}

        public List<Customer> FindCustomerDetailByCustomerId(string id)
        {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer customer = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);

            return customer.CustomerName.ToList();
        }
        //// public List<OrderDetail> FindOrderDetailByOrderId(int id)
        //public List<Customer> FindCustomerByCustomerIdWithInclude(int id)
        //{
        //    return _context.Customer.Where(detail => detail.CustomerId == id).ToList();
        //}
        //public Product GetProductById(int productId)
        //{
        //    return _context.Products.FirstOrDefault(product => product.ProductId == productId);
        //}


    }
}
