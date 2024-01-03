# Enhanced Tutorial: Creating a Custom List Class in C#

## Introduction
In this tutorial, you'll learn to create a `CustomList` class in C#, a versatile tool for managing collections of generic objects. This class will feature advanced functionalities like dynamic resizing, adding items at specific indexes, and more.

## Requirements

1. **Create a new console application** named `GA_CustomList_YourName`.
2. Implement the specified functionality.
3. **Upload to GitHub** and submit the repository link in Canvas.

---

### Starting Code
Begin with a basic console application structure in your `Program.cs` file:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Custom List Class Example");
    }
}
```

Our `CustomList` class will be a separate entity from the `Program` class.

---

### **Step 1: Creating a New Class for Custom List**

1. **Create a new class file** named `CustomList.cs`.
2. Start with the following in `CustomList.cs`:

    ```csharp
    using System;

    public class CustomList<T>
    {
        private T[] items;
        private int count;

        public CustomList() : this(10) { }

        public CustomList(int initialSize)
        {
            items = new T[initialSize];
        }

        // Additional methods will be added here.
    }
    ```

    **Explanation**: We begin with two constructors, one default and another that allows specifying the initial size. `<T>` makes our class generic.

---

### **Step 2: Implementing Add and AddAtIndex Methods**

1. **Implement the `Add` method**:

    ```csharp
    public void Add(T item)
    {
        CheckIntegrity();
        items[count++] = item;
    }
    ```

2. **Implement the `AddAtIndex` method**:

    ```csharp
    public void AddAtIndex(T item, int index)
    {
        CheckIntegrity();
        if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index));
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
        items[index] = item;
        count++;
    }
    ```

    **Explanation**: `Add` inserts items at the end, while `AddAtIndex` places items at a specified index. Both methods call `CheckIntegrity` to ensure there's enough space.

---

### **Step 3: Implementing the Remove Method**

1. **Add the `Remove` method**:

    ```csharp
    public bool Remove(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Equals(item))
            {
                for (int j = i; j < count - 1; j++)
                {
                    items[j] = items[j + 1];
                }
                count--;
                return true;
            }
        }
        return false;
    }
    ```

    **Explanation**: `Remove` searches for an item and, if found, shifts subsequent elements forward.

---

### **Step 4: Implementing CheckIntegrity and GetItem Methods**

1. **Add the `CheckIntegrity` method**:

    ```csharp
    private void CheckIntegrity()
    {
        if (count >= 0.8 * items.Length)
        {
            T[] largerArray = new T[items.Length * 2];
            Array.Copy(items, largerArray, count);
            items = largerArray;
        }
    }
    ```

2. **Implement the `GetItem` method**:

    ```csharp
    public T GetItem(int index)
    {
        if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
        return items[index];
    }
    ```

    **Explanation**: `CheckIntegrity` ensures the array size is sufficient, expanding it when 80% full. `GetItem` retrieves an item by index, with bounds checking.

---

### **Step 5: Implementing a Count Property**

1. **Add a `Count` property**:

    ```csharp
    public int Count => count;
    ```

    **Explanation**: This property provides the current item count.

---

### **Step 6: Testing Your Custom List**

1. **Test the `CustomList` in `Program.cs`**:

    ```csharp
    static void Main(string[] args)
    {
        CustomList<string> myList = new CustomList<string>();
        myList.Add("Hello");
        myList.AddAtIndex("World", 1);
        // More tests for adding, removing, and retrieving items
    }
    ```

    **Explanation**: Test your `CustomList`'s functionality, including add/remove operations and index-based manipulations.

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Class Creation** | Proper `CustomList` class with generics and constructors. | 20 |
| **Add/Remove Methods** | Correct implementation of add/remove methods, including index-based adding. | 20 |
| **CheckIntegrity/GetItem Methods** | Accurate `CheckIntegrity` and `GetItem` implementations. | 20 |
| **Count Property** | Proper implementation of `Count` property. | 10 |
| **Functionality** | Working custom list with dynamic resizing and item management. | 15 |
| **Readability/Comments** | Clear, readable code with comments. | 10 |
| **Testing** | Comprehensive testing in `Main` method. | 5 |
| **Submission** | GitHub upload and Canvas link submission. | 10 |
| **Total** |  | 100 |

This tutorial ensures you cover all aspects of implementing a custom list class with advanced features like dynamic array resizing, adding items at specific indices, and managing items effectively.