using System.Collections;

namespace CustomCollections;

internal class SpecialEnumerator<T> : IEnumerator<T>
{
    private readonly SpecialCollection<T> _aggregate;
    private int index = 0;

    public SpecialEnumerator(SpecialCollection<T> aggregate)
    {
        _aggregate = aggregate;
    }

    public T Current => _aggregate[index]! ;

    object IEnumerator.Current => _aggregate[index]!;

    public void Dispose()
    {
    //   // throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        if (index < _aggregate.Count -1) 
        { 
            if (_aggregate[++index] != null)
                return true;
        }
        return false;
    }

    public void Reset()
    {
        index = 0;
    }
}
