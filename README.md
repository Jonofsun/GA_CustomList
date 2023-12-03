
# Tutorial on Creating a Custom List Class in C#

## Introduction

This tutorial guides you through creating a custom List class in C#. We will implement methods for adding, removing, counting, and inserting elements, while ensuring the integrity of the list.

### Defining the Custom List Class
```csharp
using System;

public class CustomList<T>
{
    private T[] _items;
    private int _count;

    public CustomList()
    {
        _items = new T[4];
        _count = 0;
    }

    public int Count => _count;

    private void GrowArray()
    {
        if (_count == _items.Length)
        {
            T[] newItems = new T[_count * 2];
            Array.Copy(_items, newItems, _count);
            _items = newItems;
        }
    }

    // Method to add an item
    public void Add(T item)
    {
        GrowArray();
        _items[_count] = item;
        _count++;
    }

    // Method to remove an item
    public bool Remove(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(item))
            {
                Array.Copy(_items, i + 1, _items, i, _count - i - 1);
                _count--;
                return true;
            }
        }
        return false;
    }

    // Method to insert an item at a specific index
    public void InsertAt(int index, T item)
    {
        if (index < 0 || index > _count)
            throw new ArgumentOutOfRangeException(nameof(index));

        GrowArray();
        Array.Copy(_items, index, _items, index + 1, _count - index);
        _items[index] = item;
        _count++;
    }
}
```

### Explanation

1. **Initialization:** The `CustomList` class is initialized with an array to store items and a counter to track the number of items.
2. **Dynamic Array Resizing:** The `GrowArray` method doubles the array size when it's full, ensuring the list can grow dynamically.
3. **Adding Items:** The `Add` method appends an item to the end of the list.
4. **Removing Items:** The `Remove` method finds an item, shifts elements to fill the gap, and reduces the count.
5. **Inserting Items:** The `InsertAt` method places an item at a specified index, shifting elements as necessary.

### Conclusion

With this custom list implementation, you have a flexible and expandable data structure. It provides a hands-on understanding of how dynamic arrays like Lists work under the hood in C#.

### Further Learning
- Implement additional methods like `Clear` and `Contains`.
- Explore optimizations for large datasets.
- Compare the performance of your custom list with C#'s built-in `List<T>` class.
