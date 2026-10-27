using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        [StringLength(50)]
        public string Category { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative.")]
        public int Quantity { get; set; }

        [Range(typeof(decimal), "0", "99999999.99",
            ErrorMessage = "Enter a valid price.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100)]
        public string SupplierName { get; set; }
    }
}