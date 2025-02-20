public class MyClass {
    public int MyProperty { get; set; }

    public MyClass(int value) {
        MyProperty = value;
    }

    public static void Main(string[] args) {
        // Solution 1: Using a value type (struct)
        MyValueType instance1 = new MyValueType(10);
        MyValueType instance2 = instance1;
        instance2.MyProperty = 20; // Modifies only instance2
        Console.WriteLine(instance1.MyProperty); // Output: 10
        Console.WriteLine(instance2.MyProperty); // Output: 20

        //Solution 2: Cloning the object
        MyClass instance3 = new MyClass(10);
        MyClass instance4 = (MyClass)instance3.Clone(); // Deep Copy required for complex objects
        instance4.MyProperty = 20;
        Console.WriteLine(instance3.MyProperty); // Output: 10
        Console.WriteLine(instance4.MyProperty); // Output: 20
    }
}

//Value Type solution
public struct MyValueType
{
    public int MyProperty { get; set; }
    public MyValueType(int value) { MyProperty = value; }
}

//Implementing ICloneable for deep copy
public class MyClass : ICloneable
{
    public int MyProperty { get; set; }
    public MyClass(int value) { MyProperty = value; }
    public object Clone() { return this.MemberwiseClone(); } 
}