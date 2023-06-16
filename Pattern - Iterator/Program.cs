using System;

namespace Pattern___Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryComponent fabricBag = new Inventory(0, "Fabric bag", "Fabric pouch");
            InventoryComponent leatherBag = new Inventory(0, "Leather bag", "Leather pouch");
            InventoryComponent velvetBag = new Inventory(0, "Velvet bag", "Velvet pouch");

            InventoryComponent inventory = new Inventory(0, "InventoryBag", "Big simple bag");
            inventory.Add(fabricBag);
            inventory.Add(leatherBag);
            fabricBag.Add(velvetBag);

            fabricBag.Add(new Item(1000, "Gold coin", "10 gold coins"));
            fabricBag.Add(new Item(100, "Silver coin", "20 silver coins"));
            fabricBag.Add(new Item(5, "Copper coin", "5 copper coins"));
            velvetBag.Add(new Item(10000, "Ruby gem", "1 diamond"));

            leatherBag.Add(new Item(1, "Wood", "5 chopped logs"));
            leatherBag.Add(new Item(50, "Rope", "1 coil of rope"));

            inventory.Add(new Item(450, "Bronze sword", "Simple bronze sword"));
            inventory.Add(new Item(0, "Junk", "Various junk"));

            inventory.ShowComponent("-");
            //ShowInventory(inventory);
            Console.ReadKey();
        }

        static void ShowInventory(InventoryComponent invetory)
        {
            IIterator<InventoryComponent> iterator = invetory.CreateIterator();
            while (iterator.HasNext())
            {
                InventoryComponent component = iterator.Next();
                component.ShowComponent("-");
            }
        }
    }
}
