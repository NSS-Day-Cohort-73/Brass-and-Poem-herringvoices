//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>
{
    new Product
    {
        Name = "Trumpet",
        Price = 150.99M,
        ProductTypeId = 1,
    },
    new Product
    {
        Name = "Trombone",
        Price = 246.99M,
        ProductTypeId = 1,
    },
    new Product
    {
        Name = "Tuba",
        Price = 1250.99M,
        ProductTypeId = 1,
    },
    new Product
    {
        Name = "Ozymandias",
        Price = 12350.99M,
        ProductTypeId = 2,
    },
    new Product
    {
        Name = "Leaves of Grass",
        Price = 15650.99M,
        ProductTypeId = 2,
    },
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List.
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType { Id = 1, Title = "Brass" },
    new ProductType { Id = 2, Title = "Poem" },
};

//put your greeting here
string greeting =
    @"Welcome to Brass and Poem!
Voted #3 brass instrument and poetry shop in Nashville!";

//implement your loop here

void DisplayMenu()
{
    Console.WriteLine(
        @"1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit"
    );
}

void Menu()
{
    string choice = null;
    Console.WriteLine(greeting);
    while (choice != "5")
    {
        Console.WriteLine();
        MenuHeader();
        Console.WriteLine("Select and option:");
        DisplayMenu();

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
            $"{i + 1}. {products[i].Name} is being sold for {products[i].Price} in the '{category}' category."
        );
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine(
        "Enter the number of the product you wish to delete or enter '0' to return to the main menu:"
    );
    Console.WriteLine();

    int choice = int.Parse(Console.ReadLine().Trim());
    if (choice > 0 && choice <= products.Count)
    {
        string chosenProductName = products[choice - 1].Name;
        products.RemoveAt(choice - 1);
        Console.WriteLine(
            $"You removed '{chosenProductName}' from the list of available products."
        );
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
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

    // No extra prompts or loops to align with the test
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine(
        "Enter the number of the product you wish to update or enter 0 to return to the main menu:"
    );
    int choice = int.Parse(Console.ReadLine().Trim());

    if (choice == 0 || choice > products.Count)
    {
        return;
    }

    Product productToUpdate = products[choice - 1];

    Console.WriteLine(
        $"Current Name: {productToUpdate.Name}. Enter a new name or press 'Enter' to leave unchanged."
    );
    string updatedName = Console.ReadLine().Trim();
    if (!string.IsNullOrEmpty(updatedName))
    {
        productToUpdate.Name = updatedName;
    }

    Console.WriteLine(
        $"Current price: {productToUpdate.Price}. Enter a new price or press 'Enter' to leave unchanged."
    );
    string priceString = Console.ReadLine().Trim();
    if (!string.IsNullOrEmpty(priceString))
    {
        productToUpdate.Price = decimal.Parse(priceString);
    }

    Console.WriteLine(
        $"Current category: {productTypes.First(pt => pt.Id == productToUpdate.ProductTypeId).Title}"
    );
    Console.WriteLine("Select a new category or press 'Enter' to leave unchanged.");
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }

    string typeString = Console.ReadLine().Trim();
    if (!string.IsNullOrEmpty(typeString))
    {
        int typeChoice = int.Parse(typeString);
        productToUpdate.ProductTypeId = productTypes[typeChoice - 1].Id;
    }

    Console.WriteLine($"Product '{productToUpdate.Name}' has been updated.");
}

Menu();

// don't move or change this!
public partial class Program { }
