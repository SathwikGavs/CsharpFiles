using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCC.Models
{
    public class OrderIdsViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        private List<string> customerIds;

        public OrderIdsViewModel(List<int> orderIds)
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (var no in orderIds)
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }

        public OrderIdsViewModel(List<string> customerIds)
        {
            this.customerIds = customerIds;
        }
    }
}
