using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using InventoryManagement.Models;

namespace InventoryManagement.Data
{
    public class ProductDataAccess
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["InventoryConnection"]
            .ConnectionString;

        // READ: Get all products
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT ProductId, ProductName, Category,
                                        Quantity, Price, SupplierName
                                 FROM Products
                                 ORDER BY ProductId DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = (int)reader["ProductId"],
                                ProductName = reader["ProductName"].ToString(),
                                Category = reader["Category"].ToString(),
                                Quantity = (int)reader["Quantity"],
                                Price = (decimal)reader["Price"],
                                SupplierName = reader["SupplierName"].ToString()
                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        // READ: Get one product by ID
        public Product GetProductById(int id)
        {
            Product product = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT ProductId, ProductName, Category,
                                        Quantity, Price, SupplierName
                                 FROM Products
                                 WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = id;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {
                                ProductId = (int)reader["ProductId"],
                                ProductName = reader["ProductName"].ToString(),
                                Category = reader["Category"].ToString(),
                                Quantity = (int)reader["Quantity"],
                                Price = (decimal)reader["Price"],
                                SupplierName = reader["SupplierName"].ToString()
                            };
                        }
                    }
                }
            }

            return product;
        }

        // CREATE: Add a new product
        public bool AddProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Products
                                 (ProductName, Category, Quantity, Price, SupplierName)
                                 VALUES
                                 (@ProductName, @Category, @Quantity, @Price, @SupplierName)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 100)
                        .Value = product.ProductName;

                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50)
                        .Value = product.Category;

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int)
                        .Value = product.Quantity;

                    SqlParameter priceParameter =
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal);

                    priceParameter.Precision = 10;
                    priceParameter.Scale = 2;
                    priceParameter.Value = product.Price;

                    cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 100)
                        .Value = product.SupplierName;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // UPDATE: Modify an existing product
        public bool UpdateProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Products
                                 SET ProductName = @ProductName,
                                     Category = @Category,
                                     Quantity = @Quantity,
                                     Price = @Price,
                                     SupplierName = @SupplierName
                                 WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductId", SqlDbType.Int)
                        .Value = product.ProductId;

                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 100)
                        .Value = product.ProductName;

                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50)
                        .Value = product.Category;

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int)
                        .Value = product.Quantity;

                    SqlParameter priceParameter =
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal);

                    priceParameter.Precision = 10;
                    priceParameter.Scale = 2;
                    priceParameter.Value = product.Price;

                    cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 100)
                        .Value = product.SupplierName;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE: Remove a product
        public bool DeleteProduct(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Products WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = id;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}