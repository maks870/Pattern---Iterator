using System.Collections.Generic;

class InventoryIterator : IIterator<InventoryComponent>
{
    private int position = 0;
    private List<InventoryComponent> list;

    public InventoryIterator(List<InventoryComponent> list)
    {
        this.list = list;
    }

    public bool HasNext()
    {
        if (position < list.Count)
            return true;
        else return false;
    }

    public InventoryComponent Next()
    {
        InventoryComponent component = list[position];
        position++;
        return component;
    }
}
