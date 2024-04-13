using SanPhamChauPhu.Models;

namespace SanPhamChauPhu.Helper
{
    public class ProductHelper
    {
        
        private readonly AppDbContext _context;

        public ProductHelper(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
