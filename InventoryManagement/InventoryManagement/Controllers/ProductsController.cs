using System.Web.Mvc;
using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductDataAccess dataAccess =
            new ProductDataAccess();

        // READ: Display all products
        public ActionResult Index()
        {
            var products = dataAccess.GetAllProducts();
            return View(products);
        }

        // CREATE: Display the form
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // CREATE: Save a new product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            bool result = dataAccess.AddProduct(product);

            if (result)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(
                "",
                "Unable to save the product."
            );

            return View(product);
        }

        // READ: Display product details
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            Product product = dataAccess.GetProductById(id.Value);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // UPDATE: Display the edit form
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            Product product = dataAccess.GetProductById(id.Value);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // UPDATE: Save the changes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            bool result = dataAccess.UpdateProduct(product);

            if (result)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(
                "",
                "Unable to update the product."
            );

            return View(product);
        }

        // DELETE: Display the confirmation page
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            // Handle a missing ID safely
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            // Find the product
            Product product = dataAccess.GetProductById(id.Value);

            // Product not found
            if (product == null)
            {
                return HttpNotFound();
            }

            // Display the confirmation page
            return View(product);
        }

        // DELETE: Delete the product after confirmation
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            // Handle a missing ID safely
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            // Delete the selected product
            bool result = dataAccess.DeleteProduct(id.Value);

            if (!result)
            {
                return HttpNotFound();
            }

            // Return to the inventory list
            return RedirectToAction("Index");
        }
    }
}