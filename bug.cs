public class MyClass {
    public int MyProperty { get; set; }

    public MyClass(int value) {
        MyProperty = value;
    }

    public static void Main(string[] args) {
        MyClass instance1 = new MyClass(10);
        MyClass instance2 = instance1;
        instance2.MyProperty = 20; // Modifies both instance1 and instance2 because it's a reference type

        Console.WriteLine(instance1.MyProperty); // Output: 20
        Console.WriteLine(instance2.MyProperty); // Output: 20
    }
}