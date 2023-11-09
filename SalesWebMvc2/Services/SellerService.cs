using SalesWebMvc2.Data;
using SalesWebMvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Models
{
    public class SellerService
    {
        private readonly SalesWebMvc2Context _context;

        public SellerService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        public List<Seller> FindById()
        {
            return _context.Seller.ToList();
        }
    }
}
