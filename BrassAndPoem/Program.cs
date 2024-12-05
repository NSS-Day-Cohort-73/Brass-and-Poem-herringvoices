//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>
{
    new Product
    {
        Name = "Trumpet",
        Price = 799.99m,
        ProductTypeId = 2,
    },
    new Product
    {
        Name = "Trombone",
        Price = 699.99m,
        ProductTypeId = 2,
    },
    new Product
    {
        Name = "Tuba",
        Price = 1499.99m,
        ProductTypeId = 2,
    },
    new Product
    {
        Name = "The Emperor of Ice-Cream",
        Price = 14.99m,
        ProductTypeId = 1,
    },
    new Product
    {
        Name = "Time does not bring relief; you all have lied",
        Price = 12.99m,
        ProductTypeId = 1,
    },
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List.
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType { Id = 1, Title = "Poem" },
    new ProductType { Id = 2, Title = "Brass" },
};

//put your greeting here
string greeting =
    @"Welcome to Brass and Poem!
Voted #3 brass instrument and poetry shop in Nashville!";

//implement your loop here

void DisplayMenu()
{
    string choice = null;
    Console.WriteLine(greeting);
    while (choice != "5")
    {
        Console.WriteLine();
        MenuHeader();
        Console.WriteLine("Select and option:");
        Console.WriteLine(
            @"
        1. Display all products
        2. Delete a product
        3. Add a new product
        4. Update product properties
        5. Exit"
        );

        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine();
                InventoryHeader();
                DisplayAllProducts(products, productTypes);
                Console.WriteLine();
                WaitForReturnToMenu();
                break;

            case "2":
                Console.WriteLine();
                DeleteHeader();
                DeleteProduct(products, productTypes);
                break;

            case "3":
                Console.WriteLine();
                AddHeader();
                AddProduct(products, productTypes);
                break;

            case "4":
                Console.WriteLine();
                UpdateHeader();
                UpdateProduct(products, productTypes);
                break;

            case "5":
                Console.WriteLine();
                Console.WriteLine("Exiting Program...");
                break;
        }
    }
}
void MenuHeader()
{
    Console.WriteLine(
        @"
███╗   ███╗ █████╗ ██╗███╗   ██╗    ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
████╗ ████║██╔══██╗██║████╗  ██║    ████╗ ████║██╔════╝████╗  ██║██║   ██║
██╔████╔██║███████║██║██╔██╗ ██║    ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
██║╚██╔╝██║██╔══██║██║██║╚██╗██║    ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
██║ ╚═╝ ██║██║  ██║██║██║ ╚████║    ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
╚═╝     ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝    ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 
"
    );
}

void InventoryHeader()
{
    Console.WriteLine(
        @"
██╗███╗   ██╗██╗   ██╗███████╗███╗   ██╗████████╗ ██████╗ ██████╗ ██╗   ██╗
██║████╗  ██║██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝
██║██╔██╗ ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝ ╚████╔╝ 
██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗  ╚██╔╝  
██║██║ ╚████║ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║   ██║   
╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝   
"
    );
}

void AddHeader()
{
    Console.WriteLine(
        @"
 █████╗ ██████╗ ██████╗ 
██╔══██╗██╔══██╗██╔══██╗
███████║██   ██║██   ██║
██╔══██║██   ██║██   ██║
██║  ██║██████╔╝██████╔╝ 
╚═╝  ╚═╝╚═════╝ ╚═════╝ 
"
    );
}

void DeleteHeader()
{
    Console.WriteLine(
        @"
██████╗ ███████╗██╗     ███████╗████████╗███████╗
██╔══██╗██╔════╝██║     ██╔════╝╚══██╔══╝██╔════╝
██   ██║█████╗  ██║     █████╗     ██║   █████╗  
██   ██║██╔══╝  ██║     ██╔══╝     ██║   ██╔══╝  
██████╔╝███████╗███████╗███████╗   ██║   ███████╗
╚═════╝ ╚══════╝╚══════╝╚══════╝   ╚═╝   ╚══════╝
"
    );
}

void UpdateHeader()
{
    Console.WriteLine(
        @"
██╗   ██╗██████╗ ██████╗  █████╗ ████████╗███████╗
██║   ██║██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝
██║   ██║██████╔╝██   ██║███████║   ██║   █████╗  
██║   ██║██╔═══╝ ██   ██║██╔══██║   ██║   ██╔══╝  
╚██████╔╝██║     ██████╔╝██║  ██║   ██║   ███████╗
 ╚═════╝ ╚═╝     ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝
"
    );
}

void WaitForReturnToMenu()
{
    Console.WriteLine();
    Console.WriteLine("Hit '0' to return to the main menu.");
    while (Console.ReadLine() != "0")
    {
        Console.WriteLine("Invalid input. Hit '0' to return to the main menu.");
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        string category = productTypes
            .FirstOrDefault(item => item.Id == products[i].ProductTypeId)
            .Title;
        Console.WriteLine(
            $"{i + 1}. {products[i].Name} is being sold for {products[i].Price:C} in the '{category}' category."
        );
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    while (true)
    {
        DisplayAllProducts(products, productTypes);
        Console.WriteLine(
            "Enter the number of the product you wish to delete or enter '0' to return to the main menu:"
        );
        Console.WriteLine();
        int choice = int.Parse(Console.ReadLine().Trim());
        if (choice > 0)
        {
            string chosenProductName = products[choice - 1].Name;
            products.RemoveAt(choice - 1);
            Console.WriteLine(
                $"You removed '{chosenProductName}' from the list of available products."
            );
            Console.WriteLine("Enter 0 to return to the main menu or 1 to remove another item.");
            int nextChoice = int.Parse(Console.ReadLine().Trim());
            if (nextChoice == 1)
            {
                continue;
            }
            else if (nextChoice == 0)
            {
                break;
            }
        }
        else
        {
            break;
        }
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    while (true)
    {
        Console.WriteLine("Enter the name of the new product:");
        string productName = Console.ReadLine().Trim();

        Console.WriteLine();

        Console.WriteLine("Enter the price of the new product:");
        decimal productPrice = decimal.Parse(Console.ReadLine().Trim());

        Console.WriteLine();

        Console.WriteLine("Select a product type for the new product:");
        for (int i = 0; i < productTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
        }
        Console.WriteLine();

        int typeChoice = int.Parse(Console.ReadLine().Trim());
        int productTypeId = productTypes[typeChoice - 1].Id;

        Product newProduct = new Product
        {
            Name = productName,
            Price = productPrice,
            ProductTypeId = productTypeId,
        };
        products.Add(newProduct);

        Console.WriteLine($"'{productName}' has been added to the product list.");

        Console.WriteLine("Enter 0 to return to the main menu or 1 to add another product.");
        int nextChoice = int.Parse(Console.ReadLine().Trim());

        if (nextChoice == 1)
        {
            continue;
        }
        else if (nextChoice == 0)
        {
            break;
        }
    }
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

DisplayMenu();

// don't move or change this!
public partial class Program { }
