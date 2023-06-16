using System;

abstract class InventoryComponent
{
    protected int price;
    protected string name;
    protected string description;
    protected string indent = "|";

    protected InventoryComponent(int price, string name, string description)
    {
        this.price = price;
        this.name = name;
        this.description = description;
    }

    public void AddIndent()
    {
        indent = "-" + indent;
    }

    public virtual string GetName()
    {
        return name;
    }

    public virtual string GetDescription()
    {
        return description;
    }

    public virtual int GetPrice()
    {
        return price;
    }

    public virtual void ShowComponent(string newIndent)
    {
        indent = newIndent + indent;
        Console.WriteLine(indent + "Item name: " + name);
        Console.WriteLine(indent + "Item description: " + description);
        Console.WriteLine(indent + "Item price: " + price);
    }

    public abstract IIterator<InventoryComponent> CreateIterator();
    public abstract InventoryComponent GetChild(int index);
    public abstract void Add(InventoryComponent component);
    public abstract void Remove(InventoryComponent component);
}
