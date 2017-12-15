namespace src.ImmutableCollection
{
    public interface IImmutableCollection<T>
    {
        IImmutableCollection<T> Add(T e);
        IImmutableCollection<T> Remove(T e);
        int Size();
    }
}
