using ConsoleApp1.Models;
using ConsoleApp1.Services;
using ConsoleApp1.Data;

ItStepProjectContext context = new ItStepProjectContext();

Console.WriteLine("Welcome Press S to start");
var key = Console.ReadKey();
if (key.Key == ConsoleKey.S)
{
    Console.WriteLine("\nStarting the process...");
    Console.Clear();
    Console.WriteLine($"Type 'BR' to edit branch" +
        $"\nType 'BD' to edit brand" +
        $"\nType 'CI' to edit city" +
        $"\nType 'CT' to edit contact type" + 
        $"\nType 'CM' to edit customer" + 
        $"\nType 'CO' to edit customer order" + 
        $"\nType 'MO' to edit model" +  
        //$"\nType 'OD' to edit order details" +        
        $"\nType 'PE' to edit person" +          
        $"\nType 'PC' to edit person contact" +   
        $"\nType 'PR' to edit product" +  
        $"\nType 'PCT' to edit product category" +  
        $"\nType 'PT' to edit prdouct title" + 
        $"\nType 'ST' to edit street");   
     var asnswer = Console.ReadLine();
    switch (asnswer.ToUpper()) 
    {
        case "PE":
            PersonService personServices = new PersonService();
            Console.WriteLine("Person Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var PersonOperation = Console.ReadLine();
            if (PersonOperation.ToUpper() == "A")
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Birth Date(yyyy-MM-dd)");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter contact id");
                int contactId = Convert.ToInt32(Console.ReadLine());
                var contact = await context.PersonContacts.FindAsync(contactId);
                if (contact != null)
                {
                    Console.WriteLine("ContactId exist. Please enter a valid ContactId.");
                    break;
                }
                Person person = new Person()
                {
                    Name = firstName,
                    Surname = lastName,
                    BirthDate = birthDate,
                    ContactId = contactId
                };
                await personServices.AddAsync<Person>(person);
            }
            if (PersonOperation.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Person");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await personServices.DeleteAsync<Person>(id);
            }
            if (PersonOperation.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Person");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var person = await personServices.GetByIdAsync<Person>(id);
                Console.WriteLine($"Id: {person.Id} Name: {person.Name} Surname: {person.Surname} BirthDate: {person.BirthDate} ContactId: {person.ContactId}");
            }
            if (PersonOperation.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Persons");
                var persons = await personServices.GetAllAsync<Person>();
                foreach (var person in persons)
                {
                    Console.WriteLine($"Id: {person.Id} Name: {person.Name} Surname: {person.Surname} BirthDate: {person.BirthDate} ContactId: {person.ContactId}");
                }
            }
            break;


        case "CT":
            ContactTypeService contactServices = new ContactTypeService();
            Console.WriteLine("Contact Type Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operation = Console.ReadLine();
            if(operation.ToUpper() == "A")
            {
                Console.WriteLine("Enter Contact Name to add");
                string name = Console.ReadLine();
                ContactType contactType = new ContactType()
                {
                    Name = name
                };

                await contactServices.AddAsync<ContactType>(contactType);

            }
            else if (operation.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a contact");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                ContactType contactType = new ContactType()
                {
                    Id = id
                };
                await contactServices.DeleteAsync<ContactType>(id);

            }
            else if (operation.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 contact");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var contact = await contactServices.GetByIdAsync<ContactType>(id);
                Console.WriteLine($"Id: {contact.Id} Name: {contact.Name}");
            }
            else if (operation.ToUpper() == "ALL")
            {
                Console.WriteLine("See all contacts");
                var contacts = await contactServices.GetAllAsync<ContactType>();
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Id: {contact.Id} Name: {contact.Name}");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation selected");
            }
            break;


        case "CO":
            CustomerOrderService customerOrderServices = new CustomerOrderService();
            Console.WriteLine("Contact Type Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var Operation = Console.ReadLine();

            break;


        case "CM":
            CustomerService customerServices = new CustomerService();
            Console.WriteLine("Customer Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationCustomer = Console.ReadLine();
            if (operationCustomer.ToUpper() == "A")
            {
                Customer customer = new Customer();
                Console.WriteLine("Enter Customer's personid");
                int personid = Convert.ToInt32(Console.ReadLine());
                if(personid == customer.Id)
                {
                 Console.WriteLine("PersonId does not exist. Please enter a valid PersonId.");
                    break;
                }
                Console.WriteLine("Enter Customer's card_number(16 characters)");
                string cardNumber = Console.ReadLine();
                {
                    customer.PersonId = personid;
                    customer.CardNumber = cardNumber;
                }; 
                await customerServices.AddAsync<Customer>(customer);
            }
            if(operationCustomer.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Customer");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await customerServices.DeleteAsync<Customer>(id);
            }
            if(operationCustomer.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Customer");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var customer = await customerServices.GetByIdAsync<Customer>(id);
                Console.WriteLine($"Id: {customer.Id} PersonId: {customer.PersonId} Card Number: {customer.CardNumber}");
            }
            if(operationCustomer.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Customers");
                var customers = await customerServices.GetAllAsync<Customer>();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Id: {customer.Id} PersonId: {customer.PersonId} Card Number: {customer.CardNumber}");
                }
            }
            break;


        case "ST":
            StreetService streetServices = new StreetService();
            Console.WriteLine("Street Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationStreet = Console.ReadLine();
            if(operationStreet.ToUpper() == "A")
            {
                Street street = new Street();
                Console.WriteLine("Enter Street Name to add");
                string name = Console.ReadLine();
                street.Name = name;
                await streetServices.AddAsync<Street>(street);
            }
            if(operationStreet.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Street");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await streetServices.DeleteAsync<Street>(id);
            }
            if(operationStreet.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Street");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var street = await streetServices.GetByIdAsync<Street>(id);
                Console.WriteLine($"Id: {street.Id} Name: {street.Name}");
            }
            if(operationStreet.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Streets");
                var streets = await streetServices.GetAllAsync<Street>();
                foreach (var street in streets)
                {
                    Console.WriteLine($"Id: {street.Id} Name: {street.Name}");
                }
            }
            break;


        case "CI":
            CityServices cityServices = new CityServices();
            Console.WriteLine("City Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationCity = Console.ReadLine();

            if (operationCity?.ToUpper() == "A")
            {
                Console.WriteLine("Enter City Name to add");
                string name = Console.ReadLine();

                Console.WriteLine("Enter street id to add");
                int streetId = Convert.ToInt32(Console.ReadLine());
                var street = await context.Streets.FindAsync(streetId);
                if (street == null)
                {
                    Console.WriteLine("StreetId does not exist. Please enter a valid StreetId.");
                    break;
                }
                var existingCity = context.Cities
                    .Where(c => c.StreetId == streetId)
                    .FirstOrDefault();
                if (existingCity != null)
                {
                    Console.WriteLine($"A city with Street ID {streetId} already exists: {existingCity.Name}");
                    break;
                }
                City city = new City()
                {
                    Name = name,
                    StreetId = streetId
                };

                await cityServices.AddAsync<City>(city);
                Console.WriteLine("City added successfully!");
            }
            if(operationCity?.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a City");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await cityServices.DeleteAsync<City>(id);
            }
            if(operationCity?.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 City");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var city = await cityServices.GetByIdAsync<City>(id);
                Console.WriteLine($"Id: {city.Id} Name: {city.Name} StreetId: {city.StreetId}");
            }
            if(operationCity?.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Cities");
                var cities = await cityServices.GetAllAsync<City>();
                foreach (var city in cities)
                {
                    Console.WriteLine($"Id: {city.Id} Name: {city.Name} StreetId: {city.StreetId}");
                }
            }
            break;


        case "BR" :
            BranchServices branchServices = new BranchServices();
            Console.WriteLine("Branch Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationBranch = Console.ReadLine();
            if (operationBranch.ToUpper() == "A")
            {
                Console.WriteLine("Enter Branch Name to add");
                string name = Console.ReadLine();
                Console.WriteLine("Enter city id to add");
                int cityId = Convert.ToInt32(Console.ReadLine());
                var City = await context.Cities.FindAsync(cityId);
                if(cityId != City.Id)
                {
                    Console.WriteLine("CityId does not exist. Please enter a valid CityId.");
                    break;
                }
                Branch branch = new Branch()
                {
                    Name = name,
                    CityId = cityId
                };
                await branchServices.AddAsync<Branch>(branch);
            }
            if(operationBranch.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Branch");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await branchServices.DeleteAsync<Branch>(id);
            }
            if(operationBranch.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Branch");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var branch = await branchServices.GetByIdAsync<Branch>(id);
                Console.WriteLine($"Id: {branch.Id} Name: {branch.Name} CityId: {branch.CityId}");
            }
            if(operationBranch.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Branches");
                var branches = await branchServices.GetAllAsync<Branch>();
                foreach (var branch in branches)
                {
                    Console.WriteLine($"Id: {branch.Id} Name: {branch.Name} CityId: {branch.CityId}");
                }
            }

                break;


        case "BD":
            BrandService brandservices = new BrandService();
            Console.WriteLine("Brand Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationBrand = Console.ReadLine();
            if(operationBrand.ToUpper() == "A")
            {
                Console.WriteLine("Enter Brand Name to add");
                string name = Console.ReadLine();
                Console.WriteLine("Enter model id to add");
                int modelId = Convert.ToInt32(Console.ReadLine());
                if(modelId != context.Models.Find(modelId).Id)
                {
                    Console.WriteLine("ModelId does not exist. Please enter a valid ModelId.");
                    break;
                }
                Brand brand = new Brand()
                {
                    Name = name,
                    BrandModelId = modelId
                };
                await brandservices.AddAsync<Brand>(brand);
            }
            if (operationBrand.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Brand");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await brandservices.DeleteAsync<Brand>(id);
            }
            if (operationBrand.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Brand");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var brand = await brandservices.GetByIdAsync<Brand>(id);
                Console.WriteLine($"Id: {brand.Id} Name: {brand.Name} ModelId: {brand.BrandModelId}");
            }
            if (operationBrand.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Brands");
                var brands = await brandservices.GetAllAsync<Brand>();
                foreach (var brand in brands)
                {
                    Console.WriteLine($"Id: {brand.Id} Name: {brand.Name} ModelId: {brand.BrandModelId}");
                }
            }
            break;


        case "MO":
            ModelService modelServices = new ModelService();
            Console.WriteLine("Model Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationModel = Console.ReadLine();
            if(operationModel.ToUpper() == "A")
            {
                Console.WriteLine("Enter Model Name to add");
                string name = Console.ReadLine();
                Model model = new Model()
                {
                    Name = name
                };
                await modelServices.AddAsync<Model>(model);
            }
            if(operationModel.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Model");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await modelServices.DeleteAsync<Model>(id);
            }
            if(operationModel.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Model");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var model = await modelServices.GetByIdAsync<Model>(id);
                Console.WriteLine($"Id: {model.Id} Name: {model.Name}");
            }
            if(operationModel.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Models");
                var models = await modelServices.GetAllAsync<Model>();
                foreach (var model in models)
                {
                    Console.WriteLine($"Id: {model.Id} Name: {model.Name}");
                }
            }
            break;


        case "PC":
            PersonContactService personContactServices = new PersonContactService();
            Console.WriteLine("Person Contact Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            break;


        case "PR":
            ProductService productServices = new ProductService();
            Console.WriteLine("Product Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationProduct = Console.ReadLine();
            if(operationProduct.ToUpper() == "A")
            {
                Console.WriteLine("Enter product title id");
                int productTitleId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product price");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter product comment/description");
                string comment = Console.ReadLine();
                Console.WriteLine("Enter product brand id");
                int brandId = Convert.ToInt32(Console.ReadLine());
                Product product = new Product()
                {
                    ProductTitleId = productTitleId,
                    Price = price,
                    Comment = comment,
                    BrandId = brandId
                };
                await productServices.AddAsync<Product>(product);
            }
            if(operationProduct.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Product");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await productServices.DeleteAsync<Product>(id);
            }
            if(operationProduct.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Product");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var product = await productServices.GetByIdAsync<Product>(id);
                Console.WriteLine($"Id: {product.Id} ProductTitleId: {product.ProductTitleId} Price: {product.Price} Comment: {product.Comment} BrandId: {product.BrandId}");
            }
            if(operationProduct.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Products");
                var products = await productServices.GetAllAsync<Product>();
                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id} ProductTitleId: {product.ProductTitleId} Price: {product.Price} Comment: {product.Comment} BrandId: {product.BrandId}");
                }
            }
            break;


        case "PCT":
            ProductCategoryService productCategoryServices = new ProductCategoryService();
            Console.WriteLine("Product Category Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationProductCategory = Console.ReadLine();
            if(operationProductCategory.ToUpper() == "A")
            {
                Console.WriteLine("Enter Product Category Name to add");
                string name = Console.ReadLine();
                ProductCategory productCategory = new ProductCategory()
                {
                    Name = name
                };
                await productCategoryServices.AddAsync<ProductCategory>(productCategory);
            }
            if(operationProductCategory.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Product Category");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await productCategoryServices.DeleteAsync<ProductCategory>(id);
            }
            if(operationProductCategory.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Product Category");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var productCategory = await productCategoryServices.GetByIdAsync<ProductCategory>(id);
                Console.WriteLine($"Id: {productCategory.Id} Name: {productCategory.Name}");
            }
            if(operationProductCategory.ToUpper() == "ALL")
            {
                Console.WriteLine("See all Product Categories");
                var productCategories = await productCategoryServices.GetAllAsync<ProductCategory>();
                foreach (var productCategory in productCategories)
                {
                    Console.WriteLine($"Id: {productCategory.Id} Name: {productCategory.Name}");
                }
            }
            break;


        case "PT":
            ProductTitleService productTitleServices = new ProductTitleService();
            Console.WriteLine("Product Title Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nTo see 1 type 'SO'" +
                "\nTyoe 'ALL' to see every contact type");
            var operationProductTitle = Console.ReadLine();
            if(operationProductTitle.ToUpper() == "A")
            {
                Console.WriteLine("Enter Product Title Name to add");
                string name = Console.ReadLine();
                Console.WriteLine("Enter product category id to add");
                int productCategoryId = Convert.ToInt32(Console.ReadLine());
                await context.ProductCategories.FindAsync(productCategoryId);
                if(productCategoryId != context.ProductCategories.Find(productCategoryId).Id)
                {
                    Console.WriteLine("ProductCategoryId does not exist. Please enter a valid ProductCategoryId.");
                    break;
                }
                ProductTitle productTitle = new ProductTitle()
                {
                    Title = name,
                    ProductCategoryId = productCategoryId
                };
                await productTitleServices.AddAsync<ProductTitle>(productTitle);
            }
            if(operationProductTitle.ToUpper() == "D")
            {
                Console.WriteLine("Deleting a Product Title");
                Console.WriteLine("Enter Id to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                await productTitleServices.DeleteAsync<ProductTitle>(id);
            }
            if(operationProductTitle.ToUpper() == "SO")
            {
                Console.WriteLine("See 1 Product Title");
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                var productTitle = await productTitleServices.GetByIdAsync<ProductTitle>(id);
                Console.WriteLine($"Id: {productTitle.Id} Title: {productTitle.Title} ProductCategoryId: {productTitle.ProductCategoryId}");
            }
            break;
    }
}
else
{
    Console.WriteLine("\nInvalid key pressed. Exiting...");
}




//case "OD":
//    OrderDetailService orderDetailServices = new OrderDetailService();
//    Console.WriteLine("Order Detail Service selected");
//    Console.WriteLine("Please Choose an operation:" +
//        "\nFor add type 'A'" +
//        "\nFor Delete type 'D'" +
//        "\nTo see 1 type 'SO'" +
//        "\nTyoe 'ALL' to see every contact type");
//    var operationOrderDetail = Console.ReadLine();
//    if(operationOrderDetail.ToUpper() == "A")
//    {
//        Console.WriteLine("Enter Order Detail to add");

//    }
//    break;