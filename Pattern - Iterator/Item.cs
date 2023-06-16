using System;

class Item : InventoryComponent
{
    public Item(int price, string name, string description) : base(price, name, description)
    {
        indent = "-";
    }

    public override void Add(InventoryComponent component)
    {
        throw new NotImplementedException();
    }

    public override void Remove(InventoryComponent component)
    {
        throw new NotImplementedException();
    }

    public override InventoryComponent GetChild(int index)
    {
        throw new NotImplementedException();
    }

    public override IIterator<InventoryComponent> CreateIterator()
    {
        //indent += "-";
        return new NullIterator();
    }
}
