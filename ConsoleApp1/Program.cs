using ConsoleApp1.Models;
using ConsoleApp1.Services;

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
        $"\nType 'CO' to edit contact type" +
        $"\nType 'MO' to edit model" +  
        $"\nType 'OD' to edit order details" +     
        $"\nType 'PE' to edit person" +          
        $"\nType 'PC' to edit person contact" +   
        $"\nType 'PR' to edit product" +  
        $"\nType 'PCT' to edit product category" +  
        $"\nType 'PT' to edit prdouct title" + 
        $"\nType 'ST' to edit street");   
     var asnswer = Console.ReadLine();
    switch (asnswer.ToUpper()) 
    { 
        case "CO":
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
        case "CT":
            ContactTypeService contactTypeServices = new ContactTypeService();
            Console.WriteLine("Contact Type Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "CM":
            CustomerService customerServices = new CustomerService();
            Console.WriteLine("Customer Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "ST":
            StreetService streetServices = new StreetService();
            Console.WriteLine("Street Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "CI":
            CityServices cityServices = new CityServices();
            Console.WriteLine("City Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "BR" :
            BranchServices branchServices = new BranchServices();
            Console.WriteLine("Branch Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "BD":
            BrandService brandservices = new BrandService();
            Console.WriteLine("Brand Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;

        case "MO":
            ModelService modelServices = new ModelService();
            Console.WriteLine("Model Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "OD":
            OrderDetailService orderDetailServices = new OrderDetailService();
            Console.WriteLine("Order Detail Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "PE":
            PersonService personServices = new PersonService();
            Console.WriteLine("Person Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "PC":
            PersonContactService personContactServices = new PersonContactService();
            Console.WriteLine("Person Contact Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "PR":
            ProductService productServices = new ProductService();
            Console.WriteLine("Product Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "PCT":
            ProductCategoryService productCategoryServices = new ProductCategoryService();
            Console.WriteLine("Product Category Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
        case "PT":
            ProductTitleService productTitleServices = new ProductTitleService();
            Console.WriteLine("Product Title Service selected");
            Console.WriteLine("Please Choose an operation:" +
                "\nFor add type 'A'" +
                "\nFor Delete type 'D'" +
                "\nFor Update type 'U'");
            break;
    }
}
else
{
    Console.WriteLine("\nInvalid key pressed. Exiting...");
}







