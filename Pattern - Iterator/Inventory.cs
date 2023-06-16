using System;
using System.Collections.Generic;

class Inventory : InventoryComponent
{
    private List<InventoryComponent> inventoryComponents = new List<InventoryComponent>();
    protected IIterator<InventoryComponent> iterator = null;

    public Inventory(int price, string name, string description) : base(price, name, description)
    {
    }

    public override int GetPrice()
    {
        int finalCost = price;

        foreach (InventoryComponent component in inventoryComponents)
        {
            finalCost += component.GetPrice();
        }

        return finalCost;
    }

    public override IIterator<InventoryComponent> CreateIterator()
    {
        InventoryIterator inventoryIterator = new InventoryIterator(inventoryComponents);

        if (iterator == null)
            iterator = new CompositeIterator(inventoryIterator);

        //indent = "-" + indent;
        return iterator;
    }

    public override void Add(InventoryComponent component)
    {
        inventoryComponents.Add(component);
    }

    public override void ShowComponent(string newIndient)
    {
        base.ShowComponent(newIndient);

        indent = newIndient + indent;
        Console.WriteLine(indent + "Items inside:");

        IIterator<InventoryComponent> iterator = new InventoryIterator(inventoryComponents);
        while (iterator.HasNext())
        {
            InventoryComponent component = iterator.Next();
            component.ShowComponent(indent);
        }
    }

    public override InventoryComponent GetChild(int index)
    {
        return inventoryComponents[index];
    }

    public override void Remove(InventoryComponent component)
    {
        inventoryComponents.Remove(component);
    }

}
