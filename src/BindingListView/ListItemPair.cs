namespace NodorumSolutio.ApplicationFramework;

internal class ListItemPair<T>
{
    private IList _list;
    private ObjectView<T> _item;

    public ListItemPair(IList list, ObjectView<T> item)
    {
        _list = list;
        _item = item;
    }

    public IList List
    {
        get
        {
            return _list;
        }
    }

    public ObjectView<T> Item
    {
        get
        {
            return _item;
        }
    }
}