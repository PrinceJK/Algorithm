using System;
using System.Linq;

public class Array
{
    private int[] _array;
	private int _index;
	public Array(int arrayLength)
	{
		_array = new int[arrayLength];
	}

    public void Insert(int value)
    {
        ReSizeArray();
        _array[_index++] = value;
    }

    public int Max()
    {
        //O(n)
        int maxNumber = 0;
        int i = 1;
        int temp = _array[0];
        while (i < _index)
        {
            if (_array[i] > temp)
            {
                temp = _array[i];
            }
            i++;
        }

        return temp;
    }

    public void RemoveAt(int index)
    {
        //O(n)
        ReSizeArray();
        for (int i = index; i < _index; i++)
        {
            _array[i] = _array[i + 1];
        }
    }

    public int IndexOf(int value)
    {
        //O(n)
        for (int i = 0; i < _index; i++)
        {
            if (_array[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    public void Print()
    {
        //O(n)
        foreach (var item in _array)
        {
            Console.WriteLine(item);
        }
    }
    private void ReSizeArray()
    {
        if (_array.Length == _index)
        {
           var newArray = new int[_index * 2];
            for (int i = 0; i < _index; ++i)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }
    }

}
