# Enhanced Tutorial: Creating a Custom List Class in C#

## Introduction
This tutorial will guide you through creating a `CustomList` class in C#. Custom list classes are essential for handling collections of data with specific behaviors and properties. This class will manage a collection of generic objects, offering functionalities like adding, removing items, and tracking their count.

## Requirements

1. **Create a new console application** named `GA_CustomList_YourName`.
2. **Follow the step-by-step instructions**.
3. **Upload to GitHub** and submit the repository link in Canvas.

---

### Starting Code
Begin with a standard console application structure in your `Program.cs` file:

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

We will develop our custom list class as a separate entity from the `Program` class.

---

### **Step 1: Creating a New Class for Custom List**

1. **Create a new class file** in your project named `CustomList.cs`. This class will be generic, capable of storing any type of object.

2. In `CustomList.cs`, start with:

    ```csharp
    using System;

    public class CustomList<T>
    {
        // Additional code will be added here.
    }
    ```

    **Explanation**: `<T>` represents a generic type parameter, allowing our list to store any data type. This makes our class versatile for various data types, enhancing reusability.

---

### **Step 2: Implementing an Add Method**

1. **Define a private array** to store the items and a counter to track the number of items.

2. Inside `CustomList<T>`, start constructing the `Add` method:

    ```csharp
    private T[] items = new T[4];
    private int count;

    public void Add(T item)
    {
        // Check if array resizing is needed
        // Add the item
        // Increment the count
    }
    ```

    **Explanation**: The `Add` method will handle inserting new items into our list. We start with an initial array size and increase it as needed.

---

### **Step 3: Expanding the Array**

1. **Complete the `Add` method** to handle array resizing when it's full:

    ```csharp
    public void Add(T item)
    {
        if (count == items.Length)
        {
            T[] largerArray = new T[count * 2];
            Array.Copy(items, largerArray, count);
            items = largerArray;
        }

        items[count] = item;
        count++;
    }
    ```

    **Explanation**: When the array is full (`count == items.Length`), we create a larger array and copy the existing items. This ensures our list can dynamically grow to accommodate more items.

---

### **Step 4: Creating a Remove Method**

1. **Implement a method to remove an item** from the list:

    ```csharp
    public bool Remove(T item)
    {
        // Find the item
        // Shift the rest of the items down
        // Return true if the item was removed, otherwise false
    }
    ```

    **Explanation**: The `Remove` method locates the specified item, removes it, and then shifts any subsequent items one position back to fill the gap.

---

### **Step 5: Implementing a Count Property**

1. **Add a property to get the current item count**:

    ```csharp
    public int Count
    {
        get { return count; }
    }
    ```

    **Explanation**: This property provides a way to access the number of items currently in the list. It's a fundamental aspect of list management.

---

### **Step 6: Testing Your Custom List**

1. **In `Program.cs`, test your CustomList** by creating an instance, adding, and removing items.

    ```csharp
    static void Main(string[] args)
    {
        CustomList<string> myList = new CustomList<string>();
        myList.Add("Hello");
        myList.Add("World");
        // Test adding more items and removing them
    }
    ```

    **Explanation**: Testing in the `Main` method allows you to see your `CustomList` in action. Verify that adding and removing items behaves as expected.

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Class Creation** | Proper creation of `CustomList` class with generic handling. | 20 |
| **Add Method** | Correct `Add` method implementation including array resizing. | 20 |
| **Remove Method** | Accurate `Remove` method implementation. | 20 |
| **Count Property** | Proper `Count` property implementation. | 10 |
| **Code Functionality** | Functional custom list with add/remove capabilities. | 15 |
| **Code Readability and Comments** | Clear, readable code with explanatory comments. | 10 |
| **Testing** | Effective testing in `Main` method. | 5 |
| **Submission** | Successful GitHub upload and correct Canvas link submission. | 10 |
| **Total** |  | 100 |

This tutorial is structured to guide you through each step of implementing a custom list class, emphasizing the creation of a generic class, methods for adding and removing items, array resizing, and a count property.