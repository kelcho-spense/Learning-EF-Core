// See https://aka.ms/new-console-template for more information
using ecommerceDemo.Data;
using ecommerceDemo.Models;
using Microsoft.EntityFrameworkCore;

using EcommerceContext context = new EcommerceContext(); // create context using the using decoration

// CREATE PRODUCT

//Product product1 = new Product
//{
//    Name = "Widget",
//    Price = 2.99m
//};
//Product product2 = new Product
//{
//    Name = "Gadget",
//    Price = 4.99m
//};

//context.Products.Add(product1); // add product to the context
//context.Products.Add(product2);  // add product to the context 
//context.SaveChanges(); // save changes to the database

// SELECT PRODUCTS

//method 1
//var products = context.Products.ToList();

//Console.WriteLine(">>This is list of all product<<");
//foreach (var product in products)
//{
//    Console.WriteLine(new string('-', 40));
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//Console.WriteLine(new string('-', 40));
//}

//method 2 : using raw sql
//var products = context.Products.FromSqlRaw("SELECT * FROM Product").ToList();

//Console.WriteLine(">>This is list of all product<<");
//foreach (var product in products)
//{
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//Console.WriteLine(new string('-', 40));
//}

//method 3 : using fluent api
//var products = context.Products
//    .Where(p => p.Price > 3)
//    .OrderBy(p => p.Name);

//Console.WriteLine(">>This is list of all product<<");
//foreach (var product in products)
//{
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//Console.WriteLine(new string('-', 40));
//}

//method 4 : using linq
//var products = from product in context.Products
//               //where product.Price > 3
//               //orderby product.Name
//               select product;


//Console.WriteLine(">>This is list of all product<<");
//foreach (var product in products)
//{
//    Console.WriteLine(new string('-', 40));
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//Console.WriteLine(new string('-', 40));
//}

// UPDATE PRODUCT
//Console.WriteLine(">>Upating a product Price<<");
//var productToUpdate = context.Products
//    .Where(p => p.Name == "Widget")
//    .FirstOrDefault();

//if (productToUpdate is Product)
//{
//    productToUpdate.Price = 8.99m;
//    context.SaveChanges();
//}

//var products = from product in context.Products
//               where product.Price > 5
//               orderby product.Name
//               select product;

//foreach (var product in products)
//{
//    Console.WriteLine(new string('-', 40));
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//    Console.WriteLine(new string('-',40));
//}

// DELETE PRODUCT
//Console.WriteLine(">>Deleting a product<<");
//var productToDelete = context.Products
//    .Where(p => p.Name == "Widget")
//    .FirstOrDefault();

//context.Products.Remove(productToDelete);
//context.SaveChanges();

//var products = from product in context.Products
//               select product;
//foreach (var product in products)
//{
//    Console.WriteLine(new string('-', 40));
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//    Console.WriteLine(new string('-', 40));
//}

// INSERT MANY PRODUCTS
//Console.WriteLine(">>Inserting/fetching a list of products<<");
//List<Product> listOfProducts = new List<Product>()
//{
//    new Product { Name = "Widget", Price = 2.99m },
//    new Product { Name = "Gadget", Price = 4.99m },
//    new Product { Name = "Doohickey", Price = 3.75m },
//    new Product { Name = "Thingamabob", Price = 6.99m },
//    new Product { Name = "Whatchamacallit", Price = 1.99m },
//    new Product { Name = "Gizmo", Price = 5.99m },
//    new Product { Name = "Contraption", Price = 7.99m },
//    new Product { Name = "Mouse", Price = 3.75m },
//    new Product { Name = "Keyboard", Price = 4.25m },
//    new Product { Name = "Monitor", Price = 8.99m },
//};

//context.Products.AddRange(listOfProducts); // add range of products to the context
//context.SaveChanges(); // save changes to the database

// SELECT PRODUCTS
//var products = from product in context.Products
//               select product;
//foreach (var product in products)
//{
//    Console.WriteLine(new string('-', 40));
//    Console.WriteLine($"Product: {product.Name} - and Price : {product.Price}");
//    Console.WriteLine(new string('-', 40));
//}

// INSERT CUSTOMER
//Console.WriteLine(">>Inserting a list of customer<<");
//List<Customer> listOfCustomers = new List<Customer>()
//{
//    new Customer { FirstName = "John", LastName = "Doe", Email = "john@mail.com",Address = "123 Main St",Phone = "555-123-4567"},
//    new Customer { FirstName = "Jane", LastName = "Doe", Email = "jane@mail.com",Address = "123 Main St",Phone = "555-123-4567"},
//    new Customer { FirstName = "Sally", LastName = "Smith", Email = "sally@mail.com",Address = "123 Main St",Phone = "555-123-4567"},
//    new Customer { FirstName = "Bob", LastName = "Smith", Email = "bob@mail.com",Address = "123 Main St",Phone = "555-123-4567"},
//};

//context.Customers.AddRange(listOfCustomers); // add range of customers to the context
//context.SaveChanges(); // save changes to the database

// SELECT CUSTOMERS
//var customers = from customer in context.Customers
//                select customer;
//foreach (var customer in customers)
//{
//    Console.WriteLine(new string('-', 100));
//    Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName} - and Email : {customer.Email} Address : {customer.Address} Phone : {customer.Phone}");
//    Console.WriteLine(new string('-', 100));
//}

// INSERT ORDER
//Console.WriteLine(">>Inserting a list of order<<");
//List<Order> listOfOrders = new List<Order>()
//{
//   new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(1), CustomerID = 1},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(2), CustomerID = 2},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(3), CustomerID = 3},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(4), CustomerID = 4},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(1), CustomerID = 1},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(2), CustomerID = 2},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(3), CustomerID = 3},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(4), CustomerID = 4},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(1), CustomerID = 1},
//    new Order { OrderPlaced = DateTime.Now, OrderFulfilled = DateTime.Now.AddDays(2), CustomerID = 2},
//};

//context.Orders.AddRange(listOfOrders); // add range of orders to the context
//context.SaveChanges(); // save changes to the database

// SELECT ORDERS $ CUSTOMERS
//var orders = from order in context.Orders
//             .Include(o => o.Customer) // include customer in the query
//             select order;

//foreach (var order in orders)
//{
//    Console.WriteLine(new string('-', 150));
//    Console.WriteLine($"Order: {order.OrderPlaced} {order.OrderFulfilled} - and Customer : {order.Customer.FirstName} {order.Customer.LastName} Email : {order.Customer.Email} Address : {order.Customer.Address} Phone : {order.Customer.Phone}");
//    Console.WriteLine(new string('-', 150));
//}
//SELECT ORDER DETAILS WITH A WHERE CLAUSE

//var orders = from order in context.Orders
//                   .Include(o => o.Customer)
//                   where order.CustomerID == 1
//                   select order;

//foreach (var order in orders)
//{
//    Console.WriteLine(new string('-', 150));
//    Console.WriteLine($"Order: {order.OrderPlaced} {order.OrderFulfilled} - and Customer : {order.Customer.FirstName} {order.Customer.LastName} Email : {order.Customer.Email} Address : {order.Customer.Address} Phone : {order.Customer.Phone}");
//    Console.WriteLine(new string('-', 150));
//}

// INSERT ORDERDETAILS

Console.WriteLine(">>Inserting a list of order details<<");
List<OrderDetail> listOfOrderDetails = new List<OrderDetail>()
{
    new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 1},
    new OrderDetail { OrderId = 1, ProductId = 2, Quantity = 2},
    new OrderDetail { OrderId = 2, ProductId = 3, Quantity = 3},
    new OrderDetail { OrderId = 2, ProductId = 4, Quantity = 4},
};

context.OrderDetails.AddRange(listOfOrderDetails); // add range of order details to the context
context.SaveChanges(); // save changes to the database

// SELECT ORDERDETAILS & ORDER & CUSTOMER WITH A WHERE CLAUSE

var orderDetails = from orderDetail in context.OrderDetails
                   .Include(o => o.Order)
                   .Include(o => o.Order.Customer)
                   where orderDetail.Order.CustomerID == 1
                   select orderDetail;

foreach (var orderDetail in orderDetails)
{
    Console.WriteLine(new string('-', 180));
    Console.WriteLine($"Order: {orderDetail.Order.OrderPlaced} {orderDetail.Order.OrderFulfilled} - and Customer : {orderDetail.Order.Customer.FirstName} {orderDetail.Order.Customer.LastName}  Address : {orderDetail.Order.Customer.Address}");
    Console.WriteLine($"Order Detail: {orderDetail.Quantity} {orderDetail.Product.Name} {orderDetail.Product.Price}");
    Console.WriteLine(new string('-', 180));
}





