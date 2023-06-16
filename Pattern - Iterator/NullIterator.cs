class NullIterator : IIterator<InventoryComponent>
{
    public bool HasNext()
    {
        return false;
    }

    public InventoryComponent Next()
    {
        return null;
    }
}
