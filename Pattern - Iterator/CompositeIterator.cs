using System.Collections.Generic;

class CompositeIterator : IIterator<InventoryComponent>
{
    protected Stack<IIterator<InventoryComponent>> stack = new Stack<IIterator<InventoryComponent>>();

    public CompositeIterator(IIterator<InventoryComponent> enumerator)
    {
        stack.Push(enumerator);
    }

    public bool HasNext()
    {
        if (stack.Count == 0)
        {
            return false;
        }
        else
        {
            IIterator<InventoryComponent> iterator = stack.Peek();
            if (!iterator.HasNext())
            {
                stack.Pop();
                return HasNext();
            }
            else
            {
                return true;
            }
        }
    }

    public InventoryComponent Next()
    {
        if (HasNext())
        {
            IIterator<InventoryComponent> iterator = stack.Peek();
            InventoryComponent component = iterator.Next();

            stack.Push(component.CreateIterator());

            return component;
        }
        else
        {
            return null;
        }
    }
}
