#define DEBUG
#undef DEBUG

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using static System.Math;
using System.Xml.Linq;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloCS
{
    //sealed class MyClass
    //{
    //    public void Func()
    //    {
    //        Console.WriteLine("Func");
    //    }
    //}

    //static class ExtendMyClass
    //{
    //    static public void ExtendFunc(this MyClass myClass)
    //    {
    //        myClass.Func();
    //        Console.WriteLine("ExtendFunc");
    //    }
    //}

    class Program
    {
        //static void swap(ref int x, ref int y)
        //{
        //    int t = x;
        //    x = y;
        //    y = t;
        //}

        //static bool getVal(out int a, out int b)
        //{
        //    a = 0;
        //    b = 1;
        //    return true;
        //}

        //static int sum(params int[] args)
        //{
        //    int res = 0;
        //    foreach (int item in args)
        //    {
        //        res += item;
        //    }
        //    return res;
        //}

        //static void doit()
        //{
        //    int i = 0;
        //    double d = 1 / i;
        //    Console.WriteLine(d);
        //}

        //static public void F(string s) => Console.WriteLine($"Hello {s}!");
        //static public void F1(string s) => Console.WriteLine($"Hi {s}!");
        //public delegate void DelegateF(string s);

        //private class Juice { }
        //private class Toast { }
        //private class Bacon { }
        //private class Egg { }
        //private class Coffee { }

        //static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        //{
        //    var toast = await ToastBreadAsync(number);
        //    ApplyButter(toast);
        //    ApplyJam(toast);

        //    return toast;
        //}

        //private static Juice PourOJ()
        //{
        //    Console.WriteLine("Pouring orange juice");
        //    return new Juice();
        //}

        //private static void ApplyJam(Toast toast) =>
        //    Console.WriteLine("Putting jam on the toast");

        //private static void ApplyButter(Toast toast) =>
        //    Console.WriteLine("Putting butter on the toast");

        //private static async Task<Toast> ToastBreadAsync(int slices)
        //{
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("Putting a slice of bread in the toaster");
        //    }
        //    Console.WriteLine("Start toasting...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("Remove toast from toaster");

        //    return new Toast();
        //}

        //private static async Task<Bacon> FryBaconAsync(int slices)
        //{
        //    Console.WriteLine($"putting {slices} slices of bacon in the pan");
        //    Console.WriteLine("cooking first side of bacon...");
        //    await Task.Delay(3000);
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("flipping a slice of bacon");
        //    }
        //    Console.WriteLine("cooking the second side of bacon...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("Put bacon on plate");

        //    return new Bacon();
        //}

        //private static async Task<Egg> FryEggsAsync(int howMany)
        //{
        //    Console.WriteLine("Warming the egg pan...");
        //    await Task.Delay(3000);
        //    Console.WriteLine($"cracking {howMany} eggs");
        //    Console.WriteLine("cooking the eggs ...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("Put eggs on plate");

        //    return new Egg();
        //}

        //private static Coffee PourCoffee()
        //{
        //    Console.WriteLine("Pouring coffee");
        //    return new Coffee();
        //}

        //static async Task<int> GetValAsync()
        //{
        //    var val = 0;
        //    await Task.Delay(5000);
        //    return val;
        //}

        //static async Task Main(string[] args)

        //struct Student
        //{
        //    public int id;
        //    public string name;
        //    public float score;

        //    public override string ToString()
        //    {
        //        return id + ", " + name +  ", " + score;
        //    }
        //}

        //public class Base
        //{
        //    public virtual void Func()
        //    {
        //        Console.WriteLine("Base");
        //    }
        //}

        //public class Derived1 : Base
        //{
        //    public override void Func()
        //    {
        //        Console.WriteLine("Derived1");
        //    }
        //}

        //public class Derived2 : Base
        //{
        //    public new void Func()
        //    {
        //        Console.WriteLine("Derived2");
        //    }
        //}

        //public enum MyColor
        //{
        //    Red,
        //    Green,
        //    Blue
        //}

        //public class Base
        //{
        //    public void Func()
        //    {
        //        Console.WriteLine("Base");
        //    }
        //}

        //public class Derived : Base
        //{
        //    public new void Func()
        //    {
        //        Console.WriteLine("Derived");
        //    }
        //}

        //[StructLayout(LayoutKind.Sequential)]
        //public class MyClass
        //{
        //    public int i;
        //    protected int j;

        //    public int J => j;
        //    public int K { set; get; }

        //    public MyClass(int i, int j, int k)
        //    {
        //        this.i = i;
        //        this.j = j;
        //        K = k;
        //    }

        //    public void Print()
        //    {
        //        Console.WriteLine($"i: {i}, J: {J}, K: {K}");
        //    }
        //}

        //public class Base<T>
        //{

        //}
        //public class Derived<T> : Base<T>
        //{

        //}

        //public class Student
        //{
        //    public int id;
        //    public string name;
        //}

        //class Test
        //{
        //    public bool b = false;
        //    public int i;
        //    public string s = "Hello World!";

        //    public Test() { }

        //    public Test(bool b, int i, string s)
        //    {
        //        this.b = b;
        //        this.i = i;
        //        this.s = s;
        //    }

        //    public override string ToString()
        //    {
        //        return string.Format($"b: {b}, i: {i}, s: {s}");
        //    }
        //}

        //struct Test1
        //{
        //    public bool b;
        //    public int i;
        //    public string s;

        //    public override string ToString()
        //    {
        //        return string.Format($"b: {b}, i: {i}, s: {s}");
        //    }
        //}

        //partial class MyClass
        //{
        //    private int val;
        //    public int Val
        //    {
        //        set { val = value; }
        //        get { return val; }
        //    }

        //    public const int cval = 520;

        //    private static int sval;
        //    static MyClass()
        //    {
        //        sval = new Random().Next();
        //    }
        //    public static int Sval => sval;

        //    public int val1, val2;
        //    public int this[string index]
        //    {
        //        set
        //        {
        //            switch (index)
        //            {
        //                case nameof(val1):
        //                    val1 = value;
        //                    break;
        //                case nameof(val2):
        //                    val2 = value;
        //                    break;
        //                default:
        //                    throw new ArgumentOutOfRangeException();
        //            }
        //        }
        //        get
        //        {
        //            switch (index)
        //            {
        //                case nameof(val1):
        //                    return val1;
        //                case nameof(val2):
        //                    return val2;
        //                default:
        //                    throw new ArgumentOutOfRangeException();
        //            }
        //        }
        //    }

        //    partial void PrintSum();
        //}

        //partial class MyClass
        //{
        //    partial void PrintSum()
        //    {
        //        Console.WriteLine($"sum of val1 and val2: {val1 + val2}");
        //    }

        //    public void DoPrintSum()
        //    {
        //        PrintSum();
        //    }
        //}

        //class Base
        //{
        //    public int baseField = 520;

        //    public void BaseFunc()
        //    {
        //        Console.WriteLine("BaseFunc");
        //    }

        //    public void Func()
        //    {
        //        Console.WriteLine("Func");
        //    }

        //    virtual public void VirtualFunc()
        //    {
        //        Console.WriteLine("Base VirtualFunc");
        //    }

        //    public int field;
        //    virtual public int Field
        //    {
        //        get
        //        {
        //            return field;
        //        }
        //    }
        //}

        //class Derived : Base
        //{
        //    new public int baseField = 1314;

        //    public int derivedField = 5201314;

        //    new public void BaseFunc()
        //    {
        //        base.BaseFunc();
        //        Console.WriteLine("new BaseFunc");
        //    }

        //    public void DerivedFunc()
        //    {
        //        Console.WriteLine("DerivedFunc");
        //    }

        //    public override void VirtualFunc()
        //    {
        //        Console.WriteLine("Derived VirtualFunc");
        //    }

        //    public new int field = 1;
        //    public override int Field
        //    {
        //        get
        //        {
        //            return field;
        //        }
        //    }
        //}

        //class SecondDerived : Derived
        //{
        //    public override void VirtualFunc()
        //    {
        //        Console.WriteLine("SecondDerived VirtualFunc");
        //    }
        //}

        //static class MyMath
        //{
        //    public static double PI = Math.PI;
        //    public static double E = Math.E;

        //    static public bool IsOdd(int num)
        //    {
        //        return num % 2 == 1;
        //    }
        //    static public bool IsEven(int num)
        //    {
        //        return !IsOdd(num);
        //    }
        //}

        //public class MyInt
        //{
        //    public MyInt() { }
        //    public MyInt(int i) { Int = i; }

        //    public int Int
        //    {
        //        set; get;
        //    }

        //    public static implicit operator int(MyInt myInt)
        //    {
        //        return myInt.Int;
        //    }
        //    public static explicit operator MyInt(int i)
        //    {
        //        var myInt = new MyInt(i);
        //        return myInt;
        //    }

        //    public static MyInt operator -(MyInt myInt)
        //    {
        //        var ret = new MyInt(-myInt.Int);
        //        return ret;
        //    }
        //    public static MyInt operator -(MyInt myInt, double d)
        //    {
        //        var ret = new MyInt(myInt.Int - (int)d);
        //        return ret;
        //    }
        //    public static MyInt operator -(double d, MyInt myInt)
        //    {
        //        var ret = new MyInt((int)d - myInt.Int);
        //        return ret;
        //    }
        //    public static MyInt operator ++(MyInt myInt)
        //    {
        //        var ret = new MyInt(myInt.Int);
        //        ++ret.Int;
        //        return ret;
        //    }
        //}

        //public abstract class Shape { }
        //public class Square : Shape
        //{
        //    public double Side { get; set; }
        //}
        //public class Circle : Shape
        //{
        //    public double Radius { get; set; }
        //}
        //public class Triangle : Shape
        //{
        //    public double Height { get; set; }
        //}

        //struct MyStruct
        //{
        //    public int i;
        //    public int J { get; set; };

        //    public override string ToString()
        //    {
        //        return string.Format($"i: {i}, J: {J}");
        //    }
        //}

        //enum TrafficLight
        //{
        //    Red,
        //    Gteen,
        //    Yellow
        //}

        //[Flags]
        //enum Flag : byte
        //{
        //    Zero = 0x01,
        //    One = 0x02,
        //    Two = 0x04,
        //    Three = 0x08,
        //    Four = 0x10,
        //    Five = 0x20,
        //    Six = 0x40,
        //    Seven = 0x80
        //}

        //public delegate void F(string s);
        //static void Print(string s)
        //{
        //    Console.WriteLine(s);
        //}
        //static void PrintLowerCase(string s)
        //{
        //    Console.WriteLine(s.ToLower());
        //}
        //void PrintUpperCase(string s)
        //{
        //    Console.WriteLine(s.ToUpper());
        //}

        //public delegate int RetF();
        //static public int Ret0() { return 0; }
        //static public int Ret1() { return 1; }
        //public delegate void RetF(ref int num);
        //static public void Ret0(ref int num) { num += 0; }
        //static public void Ret1(ref int num) { num += 1; }

        //public delegate void F();

        //public delegate void PrintHandler(string s);
        //class Publisher
        //{
        //    public event PrintHandler PrintHandlers;
        //    public void StartPrint()
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            PrintHandlers?.Invoke(i.ToString());
        //        }
        //    }
        //}
        //class Subscriber
        //{
        //    public void Handler(string s)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        //interface IPeople
        //{
        //    string GetName();
        //}
        //class Teacher : IPeople
        //{
        //    public string Name { set; get; }

        //    public string GetName()
        //    {
        //        return Name;
        //    }
        //}
        //class Student : IPeople
        //{
        //    public string Name { get; set; }

        //    public string GetName()
        //    {
        //        return Name;
        //    }
        //}

        //class MyClass : IComparable
        //{
        //    public int Val { set; get; }

        //    public int CompareTo(object obj)
        //    {
        //        var rhs = (MyClass)obj;
        //        return this.Val - rhs.Val;
        //    }
        //}

        //interface IIfc1
        //{
        //    void Print(string s);
        //}
        //interface IIfc2
        //{
        //    void Print(string s);
        //}
        //class MyClass : IIfc1, IIfc2
        //{
        //    void IIfc1.Print(string s)
        //    {
        //        Console.WriteLine("IIfc1: " + s);
        //    }
        //    void IIfc2.Print(string s)
        //    {
        //        Console.WriteLine("IIfc2: " + s);
        //    }
        //    public void Print(string s)
        //    {
        //        (this as IIfc1)?.Print(s);
        //        (this as IIfc2)?.Print(s);
        //        Console.WriteLine("MyClass: " + s);
        //    }
        //}

        //class MyStack<T>
        //{
        //    private int idx = -1;
        //    private T[] stack;
        //    readonly private int capacity;
        //    public int Size
        //    {
        //        get
        //        {
        //            return idx + 1;
        //        }
        //    }
        //    public int Capacity
        //    {
        //        get
        //        {
        //            return capacity;
        //        }
        //    }

        //    public bool IsEmpty
        //    {
        //        get
        //        {
        //            return idx < 0;
        //        }
        //    }

        //    public bool IsFull
        //    {
        //        get
        //        {
        //            return idx >= capacity - 1;
        //        }
        //    }

        //    public MyStack(int capacity)
        //    {
        //        if (capacity < 0)
        //        {
        //            throw new ArgumentOutOfRangeException(nameof(capacity));
        //        }
        //        this.capacity = capacity;
        //        stack = new T[capacity];
        //    }

        //    public void push(T value)
        //    {
        //        if (IsFull)
        //        {
        //            throw new InternalBufferOverflowException();
        //        }

        //        stack[++idx] = value;
        //    }

        //    public T pop()
        //    {
        //        if (IsEmpty)
        //        {
        //            throw new InternalBufferOverflowException();
        //        }

        //        return stack[idx--];
        //    }
        //}

        static void PrintContainer<T>(T container) where T : IEnumerable
        {
            foreach (var item in container)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        //public delegate TReturn AddFunc<T1, T2, TReturn>(T1 t1, T2 t2);
        //class MyClass
        //{

        //}
        //public delegate T FCovar<out T>();
        //public delegate void FContravar<in T>(T t);

        //class ColorEnumerator : IEnumerator<string>
        //{
        //    private string[] colors;
        //    private int index = -1;

        //    public ColorEnumerator(string[] colors)
        //    {
        //        this.colors = new string[colors.Length];
        //        Array.Copy(colors, this.colors, colors.Length);
        //    }

        //    public string Current
        //    {
        //        get
        //        {
        //            if (index < 0 || index >= colors.Length)
        //            {
        //                throw new InvalidOperationException();
        //            }
        //            return colors[index];
        //        }
        //    }

        //    object IEnumerator.Current
        //    {
        //        get
        //        {
        //            if (index < 0 || index >= colors.Length)
        //            {
        //                throw new InvalidOperationException();
        //            }
        //            return colors[index];
        //        }
        //    }


        //    public void Dispose()
        //    {

        //    }

        //    public bool MoveNext()
        //    {
        //        ++index;
        //        if (index >= colors.Length)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }

        //    public void Reset()
        //    {
        //        index = -1;
        //    }
        //}
        //class ColorArray : IEnumerable<string>
        //{
        //    private string[] colors = { "Red", "Green", "Blue" };

        //    public IEnumerator<string> GetEnumerator()
        //    {
        //        return new ColorEnumerator(colors);
        //    }

        //    IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        return new ColorEnumerator(colors);
        //    }
        //}

        //class ColorArray
        //{
        //    private string[] colors = { "Red", "Green", "Blue" };

        //    public IEnumerator<string> GetEnumerator()
        //    {
        //        //for (int i = 0; i < colors.Length; i++)
        //        //{
        //        //    yield return colors[i];
        //        //}
        //        return GetEnumerable().GetEnumerator();
        //    }

        //    private IEnumerable<string> GetEnumerable()
        //    {
        //        for (int i = 0; i < colors.Length; i++)
        //        {
        //            yield return colors[i];
        //        }
        //    }
        //}

        //class Student
        //{
        //    public int Id;
        //    public string Name;
        //}
        //class StudentCourse
        //{
        //    public int Id;
        //    public string Course;
        //}

        //static Stopwatch sw = new Stopwatch();

        //static async Task<int> GetPageLength(string url)
        //{
        //    WebClient wc = new WebClient();
        //    Console.WriteLine($"start the request {url} at {sw.Elapsed.TotalMilliseconds,4:N0}");
        //    var result = await wc.DownloadStringTaskAsync(url);
        //    Console.WriteLine($"finish the request {url} at {sw.Elapsed.TotalMilliseconds,4:N0}");
        //    return result.Length;
        //}

        //static void Counting(int num)
        //{
        //    Console.WriteLine($"start counting {num:N0} at {sw.Elapsed.TotalMilliseconds,4:N0}");
        //    for (int i = 0; i < num; i++)
        //    {
        //        ;
        //    }
        //    Console.WriteLine($"stop counting {num:N0} at {sw.Elapsed.TotalMilliseconds,4:N0}");
        //}

        //static async Task Delay(int ms)
        //{
        //    await Task.Run(() => Thread.Sleep(ms));
        //}

        //static int count = 0;
        //static void Print(object state)
        //{
        //    Console.WriteLine($"{(string)state}: {++count}");
        //}

        //static void TaskMethod(string name)
        //{
        //    Console.WriteLine("Task {0} is running on a thread id {1}. Is thread pool thread: {2}",
        //        name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsThreadPoolThread);
        //}

        //static async Task Func2()
        //{
        //    Console.WriteLine($"Enter Func2, thread id: {Thread.CurrentThread.ManagedThreadId}");
        //    Console.WriteLine($"Func2 is doing something, thread id: {Thread.CurrentThread.ManagedThreadId}");
        //    await Task.Delay(2000);
        //    Console.WriteLine($"Func2 finished something, thread id: {Thread.CurrentThread.ManagedThreadId}");
        //    Console.WriteLine($"Leave Func2, thread id: {Thread.CurrentThread.ManagedThreadId}");
        //}

        //static async Task Func1()
        //{
        //    Console.WriteLine($"Enter Func1, thread id: {Thread.CurrentThread.ManagedThreadId}");
        //    await Func2();
        //    Console.WriteLine($"Leave Func1, thread id: {Thread.CurrentThread.ManagedThreadId}");
        //}

        //static void Func()
        //{
        //    try
        //    {
        //        int i = 1, j = 0;
        //        var k = i / j;
        //        Console.WriteLine(k);
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        Console.WriteLine("catch in Func");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("finally in Func");
        //    }
        //    Console.WriteLine("Func continues");
        //}

        //class MyClass
        //{
        //    public int Field1;
        //}

        //[Obsolete("Print is obsolete!")]
        //static void Print(string s)
        //{
        //    Console.WriteLine(s);
        //}
        //[Conditional("TRACE")]
        //static void TraceMsg(string msg,
        //    [CallerFilePath] string file_name = "",
        //    [CallerLineNumber] int line_no = 0,
        //    [CallerMemberName] string member_name = "")
        //{
        //    Console.WriteLine($"Called from {member_name} at {file_name} in {line_no}");
        //    Console.WriteLine(msg);
        //}

        //[AttributeUsage(AttributeTargets.Method)]
        //public sealed class MyAttributeAttribute : Attribute
        //{
        //    public string Description;
        //    public string Version;
        //    public string Reviewer;

        //    public MyAttributeAttribute(string description)
        //    {
        //        Description = description;
        //    }
        //}

        //[MyAttribute("Func", Version = "1.0", Reviewer = "Cong")]
        //static void Func()
        //{
        //    Console.WriteLine("Hello C#!");
        //}

        //[AttributeUsage(AttributeTargets.Class)]
        //public sealed class MyAttributeAttribute : Attribute
        //{
        //    public string Description;
        //    public string Version;
        //    public string Reviewer;

        //    public MyAttributeAttribute(string description, string version)
        //    {
        //        Description = description;
        //        Version = version;
        //    }
        //}

        //[MyAttribute("MyClass", "1.0.0", Reviewer = "Cong")]
        //class MyClass
        //{

        //}

        //struct MyStruct
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //    public MyStruct(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //}

        ///// <summary>
        ///// Func is a method.
        ///// </summary>
        //static public void Func()
        //{

        //}

        ///// <summary>
        ///// This is Main.
        ///// </summary>
        ///// <param name="args">Command line args</param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a string to spell-check:");
            //string stringToSpellCheck = Console.ReadLine();
            //string spellingResults;
            //int errors = 0;
            //if (stringToSpellCheck.Length == 0)
            //    spellingResults = "No string to check";
            //else
            //{
            //    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            //    Console.WriteLine("\nChecking the string for misspellings ...");
            //    app.Visible = false;
            //    Microsoft.Office.Interop.Word._Document tempDoc = app.Documents.Add();
            //    tempDoc.Words.First.InsertBefore(stringToSpellCheck);
            //    Microsoft.Office.Interop.Word.ProofreadingErrors spellErrorsColl = tempDoc.SpellingErrors;
            //    errors = spellErrorsColl.Count;

            //    //1. Without using optional parameters
            //    //object ignoreCase = true;
            //    //object alwaysSuggest = false;
            //    //object optional = Missing.Value;
            //    //tempDoc.CheckSpelling( ref optional, ref ignoreCase, ref alwaysSuggest,
            //    // ref optional, ref optional, ref optional, ref optional, ref optional,
            //    // ref optional, ref optional, ref optional, ref optional );

            //    //2. Using the "omit ref" feature
            //    object optional = Missing.Value;
            //    tempDoc.CheckSpelling(optional, true, false, optional, optional, optional, optional, optional, optional, optional, optional, optional);

            //    //3. Using "omit ref" and optional parameters
            //    //tempDoc.CheckSpelling( Missing.Value, true, false );

            //    app.Quit(false);
            //    spellingResults = errors + " errors found";
            //}
            //Console.WriteLine(spellingResults);
            //Console.WriteLine("\nPress <Enter> to exit program.");
            //Console.ReadLine();

            //var tpl = (1, 2.0, 3);
            //(int a, double b, int c) = tpl;
            //Console.WriteLine($"a: {a}, b: {b}, c: {c}");

            //MyStruct? myStruct = new MyStruct(0, 1);
            //if (myStruct.HasValue)
            //{
            //    Console.WriteLine($"X:{myStruct.Value.X}, Y:{myStruct.Value.Y}");
            //}

            //int? num = 0;
            //if (num.HasValue)
            //{
            //    Console.WriteLine(num.Value);
            //}

            //int? num = 10;
            //if (num != null)
            //{
            //    Console.WriteLine(num);
            //}

            //StringBuilder stringBuilder = new StringBuilder();
            //Console.WriteLine($"Len: {stringBuilder.Length}, Cap: {stringBuilder.Capacity}");
            //foreach (var chr in "abcdefghijklmnopqrstuvwxyz0123456789")
            //{
            //    stringBuilder.Append(chr);
            //    Console.WriteLine($"{stringBuilder}, Len: {stringBuilder.Length}, Cap: {stringBuilder.Capacity}");
            //}

            //var type = typeof(MyClass);
            //var b = type.IsDefined(typeof(MyAttributeAttribute));
            //Console.WriteLine(b ? "Yes" : "No");
            //var attrs = type.GetCustomAttributes();
            //foreach (var attr in attrs)
            //{
            //    if (attr is MyAttributeAttribute myAttr)
            //    {
            //        Console.WriteLine($"Description: {myAttr.Description}, Version: {myAttr.Version}, Reviewer: {myAttr.Reviewer}");
            //    }
            //}

            //Func();

            //TraceMsg("msg1");
            //Console.WriteLine("Hello World!");
            //TraceMsg("msg2");

            //Print("Hello World");

            //MyClass myClass = new MyClass();
            //Console.WriteLine(myClass.GetType() == typeof(MyClass));
            //var type = myClass.GetType();
            //foreach (var item in type.GetFields())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //#region PRINT
            //Console.WriteLine("Hello World!");
            //#endregion

            //#line hidden
            //            Console.WriteLine("Hello CS!");
            //            Console.WriteLine("Hello C#!");
            //#line default
            //            Console.WriteLine("Hello World!");

            //#if DEBUG
            //#error An Error occured.
            //#endif

            //#warning A Warning.

            //#if DEBUG
            //            Console.WriteLine("DEBUG");
            //#else
            //            Console.WriteLine("NO DEBUG");
            //#endif

            //try
            //{
            //    Func();
            //    Console.WriteLine("after Func");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("catch in Main");
            //}
            //finally
            //{
            //    Console.WriteLine("finally in Main");
            //}
            //Console.WriteLine("Main continues");

            //try
            //{
            //    int i = 1, j = 0;
            //    var k = i / j;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Message:\n{e.Message}");
            //    Console.WriteLine($"StackTrace:\n{e.StackTrace}");
            //    Console.WriteLine($"InnerException:\n{e.InnerException}");
            //    Console.WriteLine($"Source:\n{e.Source}");
            //    Console.WriteLine($"HelpLink:\n{e.HelpLink}");
            //    Console.WriteLine($"TargetSite:\n{e.TargetSite}");
            //    throw;
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}

            //Console.WriteLine($"Enter Main, thread id: {Thread.CurrentThread.ManagedThreadId}");
            //var task = Func1();
            ////Console.WriteLine($"{task.Status}");
            //Console.WriteLine($"Main is doing something, thread id: {Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(5000);
            //Console.WriteLine($"Main finished something, thread id: {Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine($"Finish Main, thread id: {Thread.CurrentThread.ManagedThreadId}");
            ////Console.WriteLine($"{task.Status}");

            //var t1 = new Task(() => TaskMethod("Task 1"));
            //var t2 = new Task(() => TaskMethod("Task 2"));
            //t2.Start();
            //t1.Start();
            //Task.WaitAll(t1, t2);
            //Task.Run(() => TaskMethod("Task 3"));
            //Task.Factory.StartNew(() => TaskMethod("Task 4"));
            ////标记为长时间运行任务,则任务不会使用线程池,而在单独的线程中运行。
            //Task.Factory.StartNew(() => TaskMethod("Task 5"), TaskCreationOptions.LongRunning);

            //#region 常规的使用方式
            //Console.WriteLine("主线程执行业务处理.");
            ////创建任务
            //Task task = new Task(() =>
            //{
            //    Console.WriteLine("使用System.Threading.Tasks.Task执行异步操作.");
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            ////启动任务,并安排到当前任务队列线程中执行任务(System.Threading.Tasks.TaskScheduler)
            //task.Start();
            //Console.WriteLine("主线程执行其他处理");
            //task.Wait();
            //#endregion

            //Thread.Sleep(TimeSpan.FromSeconds(1));
            //Console.ReadLine();

            //var timer = new Timer(Print, "current count", 0, 1000);
            //Console.ReadKey();

            // https://devblogs.microsoft.com/dotnet/migrating-delegate-begininvoke-calls-for-net-core/
            //var sum = new Func<int, int, int>((a, b) => a + b);
            //var iar = sum.BeginInvoke(1, 2, null, null);
            //var result = sum.EndInvoke(iar);
            //Console.WriteLine(result);

            //const int length = 20000;
            //long[] arr = new long[length];
            //Parallel.For(0, length, i =>
            //{
            //    arr[i] = i * i;
            //    //Console.WriteLine($"{i} * {i} = {i * i}");
            //});
            //Parallel.ForEach(arr, i =>
            //{
            //    Console.WriteLine(i);
            //});

            //var task = Delay(1000);
            //task.Wait();

            //sw.Start();
            //string url1 = "http://www.microsoft.com";
            //string url2 = "http://www.baidu.com";
            //var t1 = GetPageLength(url1);
            //var t2 = GetPageLength(url2);
            //const int largeNumber = 600_000_000;
            //Counting(largeNumber);
            //Counting(largeNumber);
            //Counting(largeNumber);
            //Console.WriteLine($"length of {url1}: {t1.Result}");
            //Console.WriteLine($"length of {url2}: {t2.Result}");

            //XDocument employeeDoc =
            //    new XDocument(
            //        new XElement("Employees",
            //            new XElement("Employee",
            //                new XElement("Name", "Bob Smith"),
            //                new XElement("PhoneNumber", "408-555-1000")
            //            ),
            //            new XElement("Employee",
            //                new XElement("Name", "Sally Jones"),
            //                new XElement("PhoneNumber", "415-555-2000"),
            //                new XElement("PhoneNumber", "415-555-2001")
            //            )
            //        )
            //);
            //employeeDoc.Save("employees.xml");

            //var root = employeeDoc.Element("Employees");
            //foreach (var employee in root.Elements())
            //{
            //    var name = employee.Element("Name").Value;
            //    Console.WriteLine(name);
            //    foreach (var phone in employee.Elements("PhoneNumber"))
            //    {
            //        Console.WriteLine($"    {phone.Value}");
            //    }
            //}

            //XDocument employees = new XDocument(
            //    new XElement("employees",
            //        new XElement("name", "wang"),
            //        new XElement("name", "liu")
            //    )
            //);
            //employees.Save("employees.xml");
            //employees = XDocument.Load("employees.xml");
            //Console.WriteLine(employees);

            //int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = arr.TakeWhile(num => num < 5);
            //PrintContainer(query);
            //query = arr.OrderByDescending(num => num);
            //PrintContainer(query);
            //Console.WriteLine(arr.FirstOrDefault());
            //Console.WriteLine(arr.FirstOrDefault(num => num > 9));
            //string[] strs = { };
            //var str = strs.FirstOrDefault();
            //Console.WriteLine(str ?? "null");
            //var arr1 = Enumerable.Repeat(0, 10).ToArray();
            //PrintContainer(arr1);
            //Console.WriteLine(Enumerable.SequenceEqual(arr, arr1));

            //Student[] students = {
            //    new Student { Id = 0, Name = "Wang" },
            //    new Student { Id = 1, Name = "Liu" },
            //    new Student { Id = 2, Name = "Zhang" }
            //};
            //StudentCourse[] studentCourses =
            //{
            //    new StudentCourse { Id = 0, Course = "Math" },
            //    new StudentCourse { Id = 0, Course = "English" },
            //    new StudentCourse { Id = 1, Course = "English" },
            //    new StudentCourse { Id = 1, Course = "Language" },
            //    new StudentCourse { Id = 2, Course = "Physics" },
            //    new StudentCourse { Id = 2, Course = "Chemistry" }
            //};
            //var queryName = from s in students
            //                join sc in studentCourses
            //                on s.Id equals sc.Id
            //                where sc.Course == "English"
            //                orderby s.Name
            //                select s.Name;
            //foreach (var item in queryName)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //var queryName1 = from s in students
            //                 join sc in studentCourses
            //                 on s.Id equals sc.Id
            //                 into temp
            //                 from stu in temp
            //                 where stu.Course == "Math"
            //                 orderby s.Name ascending
            //                 select s.Name;
            //foreach (var item in queryName1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //var queryCourse = from s in students
            //                  join sc in studentCourses
            //                  on s.Id equals sc.Id
            //                  where s.Name == "Zhang"
            //                  orderby sc.Course descending
            //                  select sc.Course;
            //foreach (var item in queryCourse)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //var queryCourse1 = from s in students
            //                   join sc in studentCourses
            //                   on s.Id equals sc.Id
            //                   into temp
            //                   from stu in temp
            //                   group stu by stu.Id;
            //foreach (var grp in queryCourse1)
            //{
            //    Console.WriteLine(grp.Key + ":");
            //    foreach (var stu in grp)
            //    {
            //        Console.WriteLine("  " + stu.Course);
            //    }
            //}

            //double Score = 100;
            //var student = new { Name = "Cong Wang", age = 24, Score };
            //Console.WriteLine(student);

            //string[] strs = { "good", "Bad", "Hello", "world" };
            //var lowercaseStrs = from str in strs where str.All(c => char.IsLower(c)) select str;
            //foreach (var str in lowercaseStrs)
            //{
            //    Console.WriteLine(str);
            //}

            //var colorArray = new ColorArray();
            //foreach (var color in colorArray)
            //{
            //    Console.WriteLine(color);
            //}

            //int[] arr = { 1, 2, 3, 4, 5 };
            //var iter = arr.GetEnumerator();
            //while (iter.MoveNext())
            //{
            //    Console.WriteLine(iter.Current);
            //}

            //FCovar<MyClass> f = () => new MyClass();
            //FCovar<object> f1 = f;
            //f1();
            //FContravar<object> ff = (object o) => { };
            //FContravar<MyClass> ff1 = ff;
            //ff1(new MyClass());

            //AddFunc<int, int, string> add = (int i, int j) => (i + j).ToString();
            //Console.WriteLine(add(1, 2));

            //var arr = new int[] { 1, 2, 3, 4, 5 };
            //PrintContainer(arr);

            //var st = new MyStack<int>(10);
            //for (int i = 0; i < st.Capacity; i++)
            //{
            //    st.push(i);
            //}
            //Console.WriteLine($"Size: {st.Size}");
            //for (int i = 0; i < st.Capacity; i++)
            //{
            //    Console.Write($"{st.pop()} ");
            //}
            //Console.WriteLine($"\nSize: {st.Size}");


            //var d = -1e-200;
            //var d = 1e200;
            //var f = (float)d;
            //Console.WriteLine($"d: {d}, f: {f}");

            //var d = 255M;
            //var b = (byte)d;
            //Console.WriteLine($"d: {d}, b: 0x{b:X}");

            //float f = -300.5234f;
            //byte b = (byte)f;
            //Console.WriteLine($"f: {f}, b: 0x{b:X}, -300: 0x{-300:X}");

            //var myClass = new MyClass();
            //myClass.Print("Hello World!");

            //var ifc1 = myClass as IIfc1;
            //var ifc2 = myClass as IIfc2;
            //ifc1?.Print("Hello World!");
            //ifc2?.Print("Hello World!");

            //MyClass[] arr = new MyClass[10];
            //var random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new MyClass()
            //    {
            //        Val = random.Next() % 10
            //    };
            //}
            //foreach (var item in arr)
            //{
            //    Console.Write(item.Val + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item.Val + " ");
            //}
            //Console.WriteLine();

            //int[] arr = new int[10];
            //var random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next();
            //}
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(arr);
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //IPeople p1 = new Teacher() { Name = "Liu" };
            //IPeople p2 = new Student() { Name = "Wang" };
            //Console.WriteLine(p1.GetName());
            //Console.WriteLine(p2.GetName());

            //Publisher publisher = new Publisher();
            //Subscriber subscriber = new Subscriber();
            //publisher.PrintHandlers += subscriber.Handler;
            //publisher.StartPrint();

            //int x = 520;
            //F f = delegate ()
            //{
            //    Console.WriteLine(x += 1);
            //};
            //f += delegate ()
            //{
            //    Console.WriteLine(x += 2);
            //};
            //f();
            //f = () => Console.WriteLine(x += 1);
            //f += () => Console.WriteLine(x += 2);
            //f();

            //RetF f = Ret0;
            //f += Ret1;
            //int num = 0;
            //f(ref num);
            //Console.WriteLine(num);

            //F f;
            //f = Print;
            //f("Hello World!");
            //Console.WriteLine();
            //f = PrintLowerCase;
            //f("Hello World!");
            //Console.WriteLine();
            //f += Print;
            //f += Print;
            //f("Hello World!");
            //Console.WriteLine();
            //f -= Print;
            //f("Hello World!");
            //Console.WriteLine();
            //f -= Print;
            //f("Hello World!");
            //Console.WriteLine();
            //f -= PrintLowerCase;
            //if (f != null)
            //{
            //    f("Hello World!");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("f is null");
            //}
            //f?.Invoke("Hello World!");
            //Console.WriteLine();
            //Program program = new Program();
            //F f1 = program.PrintUpperCase;
            //f1?.Invoke("Hello World!");

            //int[,] arr = { { 1, 2 }, { 3, 4 } };
            //Console.WriteLine($"info: {arr.Rank}, {arr.Length}");
            //foreach (var a in arr)
            //{
            //    Console.WriteLine(a);
            //}

            //int[][] arr1 = new int[2][]
            //{
            //    new int[2] {1,2},
            //    new int[2] {3,4}
            //};
            //Console.WriteLine($"info: {arr1.Rank}, {arr1.Length}");
            //foreach (var subarr in arr1)
            //{
            //    foreach (var a in subarr)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}

            //int[][,] arr2 = new int[2][,]
            //{
            //    new int[2,3] {{1,2,3}, {4,5,6}},
            //    new int[2,3] {{7,8,9}, {10,11,12}}
            //};
            //Console.WriteLine($"info: {arr2.Rank}, {arr2.Length}");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr2[i].GetLength(0); j++)
            //    {
            //        for (int k = 0; k < arr2[i].GetLength(1); k++)
            //        {
            //            Console.WriteLine(arr2[i][j, k]);
            //        }
            //    }
            //}

            //int i = 1, j = 2, k = 3;
            //int res = i + j + k;
            //Console.WriteLine($"i + j + k = {res}");

            //Flag flag = Flag.Zero | Flag.Four;
            //Console.WriteLine($"flag has Zero: {flag.HasFlag(Flag.Zero)}");
            //Console.WriteLine($"flag has Six: {flag.HasFlag(Flag.Six)}");
            //Console.WriteLine($"{flag}");

            //TrafficLight l1 = TrafficLight.Red;
            //Console.WriteLine($"{l1} : {(int)l1}");

            //MyStruct myStruct = new MyStruct();
            //Console.WriteLine(myStruct);

            //var lists = new List<int>()
            //{
            //    1,2,3,4
            //};
            //foreach (var i in lists)
            //{
            //    Console.WriteLine(i);
            //}

            //using (TextWriter textWriter = File.CreateText("test.txt"))
            //{
            //    textWriter.WriteLine("Hello World!");
            //}
            //using (TextReader textReader = File.OpenText("test.txt"))
            //{
            //    Console.Write(textReader.ReadToEnd());
            //}

            //var shapes = new List<Shape>();
            //shapes.Add(new Circle() { Radius = 7 });
            //shapes.Add(new Square() { Side = 5 });
            //shapes.Add(new Triangle() { Height = 4 });
            //var nullSquare = (Square)null;
            //shapes.Add(nullSquare);
            //foreach (var shape in shapes)
            //{
            //    switch (shape) //Evaluate the type and/or value of variable shape.
            //    {
            //        case Circle circle: //Equivalent to if(shape is Circle)
            //            Console.WriteLine($"This shape is a circle of radius { circle.Radius }");
            //            break;
            //        case Square square when square.Side > 10: //Matches only a subset of Squares
            //            Console.WriteLine($"This shape is a large square of side { square.Side }");
            //            break;
            //        case Square square:
            //            Console.WriteLine($"This shape is a square of side { square.Side }");
            //            break;
            //        case Triangle triangle: // Equivalent to if(shape is Triangle)
            //            Console.WriteLine($"This shape is a triangle of side { triangle.Height }");
            //            break;
            //        //case Triangle triangle when triangle.Height < 5: //Compile error
            //        //Console.WriteLine($"This shape is a triangle of side { triangle.Height }");
            //        //break;
            //        case null:
            //            Console.WriteLine($"This shape could be a Square, Circle or a Triangle");
            //            break;
            //        default:
            //            throw new ArgumentException(
            //            message: "shape is not a recognized shape",
            //            paramName: nameof(shape));
            //    }
            //}

            //MyInt myInt = new MyInt(520);
            //Console.WriteLine($"before: {myInt.Int}");
            //var t = ++myInt;
            //Console.WriteLine($"++myInt: {t.Int}");
            //Console.WriteLine($"after: {myInt.Int}");
            //Console.WriteLine($"before: {myInt.Int}");
            //t = myInt++;
            //Console.WriteLine($"++myInt: {t.Int}");
            //Console.WriteLine($"after: {myInt.Int}");

            //MyInt myInt = new MyInt(520);
            //myInt = -myInt;
            //Console.WriteLine(myInt.Int);
            //myInt -= -20.0;
            //Console.WriteLine(myInt.Int);
            //myInt = 20.0 - myInt;
            //Console.WriteLine(myInt.Int);

            //MyInt myInt = new MyInt(520);
            //int i = myInt;
            //Console.WriteLine(i);
            //i = 1314;
            //myInt = (MyInt)i;
            //Console.WriteLine(myInt.Int);

            //int a = 0;
            //string s = "Hello World!";
            //var rd = new Random();
            //Console.WriteLine(rd.NextDouble());

            //int a = int.MaxValue;
            //Console.WriteLine(a);
            //Console.WriteLine($"{a:X}");
            //a = int.MinValue;
            //Console.WriteLine(a);
            //Console.WriteLine($"{a:X}");

            //var a = 1 / 2;
            //Console.WriteLine(a);

            //Console.WriteLine("\u4f60\u597d\uff0c\u4e16\u754c\uff01");

            //Console.WriteLine(Int32.MaxValue);
            //Console.WriteLine(Int32.MinValue);

            //var myClass = new MyClass();
            //myClass.ExtendFunc();

            //Console.WriteLine(MyMath.PI);
            //Console.WriteLine(MyMath.IsEven(2));

            //Derived d = new Derived();
            //Console.WriteLine(d.baseField);
            //Console.WriteLine(d.derivedField);
            //d.BaseFunc();
            //d.DerivedFunc();
            //d.Func();
            //var d = new Derived();
            //var b = (Base)d;
            //Console.WriteLine(b.baseField);
            //b.Func();
            //b.BaseFunc();
            //var d = new Derived();
            //var b = (Base)d;
            //b.VirtualFunc();
            //Console.WriteLine(b.Field);
            //var sd = new SecondDerived();
            //var d = (Derived)sd;
            //d.VirtualFunc();

            //var myClass = new MyClass()
            //{
            //    val1 = 520,
            //    val2 = 1314
            //};
            //myClass.DoPrintSum();

            //MyClass myClass = new MyClass()
            //{
            //    val1 = 0,
            //    val2 = 1
            //};
            //Console.WriteLine($"val1: {myClass["val1"]}, val2: {myClass["val2"]}");

            //Console.WriteLine(MyClass.Sval);

            //MyClass myClass = new MyClass();
            //Console.WriteLine(myClass.Val);
            //MyClass.Sval = 520;
            //Console.WriteLine(MyClass.Sval);
            //Console.WriteLine(MyClass.cval);

            //void func(int a, int b, int c)
            //{
            //    Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            //}
            //func(1, 2, 3);
            //func(c: 3, b: 2, a: 1);

            //int i = 0;
            //Console.WriteLine($"i: {i}");
            //ref int j = ref i;
            //++j;
            //Console.WriteLine($"i: {i}, j: {j}");

            //void LocalFunc()
            //{
            //    Console.WriteLine("Hello C#!");
            //}
            //LocalFunc();

            //var t = new Test();
            //Console.WriteLine(t);
            //var t1 = new Test(true, 520, "Hello C#");
            //Console.WriteLine(t1);

            //var t = new Test();
            //Console.WriteLine(t);
            //var t1 = new Test();
            //Console.WriteLine(t1);

            //var str = "你好，世界！";
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str);

            //var pi = Math.PI;
            //Console.WriteLine($"{pi,-10:G} -- General");
            //Console.WriteLine($"{pi,-10} -- Default, same as General");
            //Console.WriteLine($"{pi,-10:F4} -- Fixed Point, 4 dec places");
            //Console.WriteLine($"{pi,-10:C} -- Currency");
            //Console.WriteLine($"{pi,-10:E3} -- Sci. Notation, 3 dec places");
            //Console.WriteLine($"{1194719,-10:X} -- Hexadecimal integer");
            //Console.WriteLine($"{pi,10:G} -- General");
            //Console.WriteLine($"{pi,10} -- Default, same as General");
            //Console.WriteLine($"{pi,10:F4} -- Fixed Point, 4 dec places");
            //Console.WriteLine($"{pi,10:C} -- Currency");
            //Console.WriteLine($"{pi,10:E3} -- Sci. Notation, 3 dec places");
            //Console.WriteLine($"{1194719,10:X} -- Hexadecimal integer");

            //var val = 500;
            //Console.WriteLine($"|{val,10}|");
            //Console.WriteLine($"|{val,-10}|");

            //Console.WriteLine("money: {0:C}", 1000);
            //var money = 1000;
            //Console.WriteLine($"money: {money:C}");

            //string[] strs = { "Hello", "World" };
            //var s = string.Join(" ", strs);
            //Console.WriteLine(s);

            //var student = new Student
            //{
            //    id = 0,
            //    name = "Cong Wang"
            //};
            //var json = JsonConvert.SerializeObject(student);
            //Console.WriteLine(json);

            //Console.WriteLine("Hello World!");

            //Console.WriteLine("{0}, {1}", 1, 2);
            //Console.WriteLine("{1}, {0}", 1, 2);
            //Console.WriteLine($"{0}, {1}");

            //var key = Console.ReadKey();
            //Console.WriteLine(key.KeyChar);

            //var c = Console.Read();
            //var ch = (char)c;
            //Console.WriteLine(ch);

            //var line = Console.ReadLine();
            //Console.WriteLine(line);

            //string s = "";
            //Console.WriteLine(s == null);
            //Console.WriteLine(s.Length);

            //Console.WriteLine(args == null);
            //Console.WriteLine(args.Length);
            //foreach (var arg in args)
            //{
            //    Console.WriteLine(arg);
            //}

            //string s = "1;2;3;";
            //var arr = s.Split(';');
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr[3] == null);
            //Console.WriteLine(arr[3] == "");

            //// Specify the data source.
            //int[] scores = new int[] { 97, 92, 81, 60 };

            //// Define the query expression.
            //IEnumerable<int> scoreQuery =
            //    from score in scores
            //    where score > 80
            //    select score;

            //// Execute the query.
            //foreach (int i in scoreQuery)
            //{
            //    Console.Write(i + " ");
            //}

            //var valTask = GetValAsync();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //var val = await valTask;
            //Console.WriteLine($"GetValAsync: {val}");

            //string s = null;
            //string ss = s?.ToLower();
            //Console.WriteLine(ss);
            //Console.WriteLine(ss == null);

            //Coffee cup = PourCoffee();
            //Console.WriteLine("coffee is ready");

            //var eggsTask = FryEggsAsync(2);
            //var baconTask = FryBaconAsync(3);
            //var toastTask = MakeToastWithButterAndJamAsync(2);

            //var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            //while (breakfastTasks.Count > 0)
            //{
            //    Task finishedTask = await Task.WhenAny(breakfastTasks);
            //    if (finishedTask == eggsTask)
            //    {
            //        Console.WriteLine("eggs are ready");
            //    }
            //    else if (finishedTask == baconTask)
            //    {
            //        Console.WriteLine("bacon is ready");
            //    }
            //    else if (finishedTask == toastTask)
            //    {
            //        Console.WriteLine("toast is ready");
            //    }
            //    breakfastTasks.Remove(finishedTask);
            //}

            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");
            //Console.WriteLine("Breakfast is ready!");

            //try
            //{
            //    var e = new ArgumentNullException(nameof(args));
            //    throw e;
            //}
            //catch (Exception e)
            //{

            //    Console.Error.WriteLine($"{e.Message}\n{e.StackTrace}");
            //    Console.Error.WriteLine($"{e}");
            //}

            //var d = new Derived<int>();
            //Console.WriteLine(d.GetType().FullName);
            //Console.WriteLine(d.GetType().BaseType.FullName);

            //var set1 = new HashSet<int>() { 0, 1, 1, 2, 5, 6 };
            //var set2 = new HashSet<int>() { 5, 5, 6, 0, 0, 1, 1, 2 };
            //Console.WriteLine(set1.Equals(set2));
            //Console.WriteLine(set1.SetEquals(set2));
            //Console.WriteLine(set1);
            //var dict = new Dictionary<int, string>() { { 0, "0" } };
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item);
            //}

            //var d = new Derived();
            //Console.WriteLine(d.GetType().BaseType.FullName);
            //Console.WriteLine(typeof(Base).FullName);

            //List<Base> l = new List<Base>() { new Derived() };
            //Console.WriteLine((l as ICollection<Derived>)?.Count);

            //var s = new string("Hello World!");
            //object o = s;
            //if (o is string)
            //{
            //    Console.WriteLine("is string");
            //}
            //if (o is IEnumerable)
            //{
            //    Console.WriteLine("is IEnumerable");
            //}
            //if (o is ICollection)
            //{
            //    Console.WriteLine("is ICollection");
            //}
            //string s = "a";
            //string str = s;
            //Console.WriteLine(s == str);
            //s = "b";
            //Console.WriteLine(s == str);
            //string s1 = "a";
            //string s2 = new string("a");
            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1.Equals(s2));

            //var list = new List<int>();
            //var listType = typeof(List<>);
            //Console.WriteLine(listType.FullName);
            //var elementType = list.GetType().GetGenericArguments()[0];
            //Console.WriteLine(elementType.FullName);
            //var outputListType = listType.MakeGenericType(new Type[] { elementType });
            //Console.WriteLine(outputListType.FullName);
            //var outputList = Activator.CreateInstance(outputListType);
            //Console.WriteLine(outputList.GetType().FullName);
            //var addMethod = outputList.GetType().GetMethod("Add");
            //addMethod.Invoke(outputList, new object[] { 0 });
            //foreach (var item in outputList as IEnumerable)
            //{
            //    Console.WriteLine(item);
            //}

            //var map = new Dictionary<int, string>();
            //var m = map as IEnumerable;
            //Console.WriteLine(m.GetType().FullName);

            //var type = m.GetType();
            //var type = typeof(IEnumerable<KeyValuePair<int, string>>);
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.FullName);

            //var @interface = type.GetInterface("System.Collections.Generic.ICollection`1");
            //Console.WriteLine(@interface);
            //var methods = @interface.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method);
            //}
            //var addMethod = @interface.GetMethod("Add");
            //var dict = Activator.CreateInstance(type);
            //var kv = new KeyValuePair<int, string>(0, "0");
            //addMethod.Invoke(dict, new object[] { kv });
            //foreach (var item in dict as IEnumerable)
            //{
            //    Console.WriteLine(item);
            //}

            /*
             * System.Collections.Generic.IDictionary`2[System.Int32,System.String]
             * System.Collections.Generic.ICollection`1[System.Collections.Generic.KeyValuePair`2[System.Int32,System.String]]
             * System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.Int32,System.String]]
             * System.Collections.IEnumerable
             * System.Collections.IDictionary
             * System.Collections.ICollection
             * System.Collections.Generic.IReadOnlyDictionary`2[System.Int32,System.String]
             * System.Collections.Generic.IReadOnlyCollection`1[System.Collections.Generic.KeyValuePair`2[System.Int32,System.String]]
             * System.Runtime.Serialization.ISerializable
             * System.Runtime.Serialization.IDeserializationCallback
             */
            //foreach (var @interface in type.GetInterfaces())
            //{
            //    Console.WriteLine(@interface);
            //}
            //Console.WriteLine(type);
            //if (type.IsGenericType)
            //{
            //    var types = type.GetGenericArguments();
            //    foreach (var t in types)
            //    {
            //        Console.WriteLine(t);
            //    }
            //}


            //IEnumerable<Base> l = new List<Base>() { new Derived() };
            //Console.WriteLine(l.GetType());

            //(int, string, double) unnamedTup = (1, "2", 3.0);
            //Console.WriteLine(unnamedTup);
            //Console.WriteLine($"({unnamedTup.Item1}, {unnamedTup.Item2}, {unnamedTup.Item3})");
            //(int first, string second, double third) namedTup = unnamedTup;
            //Console.WriteLine(namedTup);
            //Console.WriteLine($"({namedTup.first}, {namedTup.second}, {namedTup.third})");
            //(var first, var second, var third) = namedTup;
            //Console.WriteLine($"first: {first}, second: {second}, third: {third}");

            //var unnamedTuple = (1, "two", 3.0, "four");
            //Console.WriteLine(unnamedTuple);
            //var namedTuple = (first: 1, second: "Two", third: 3.0);
            //Console.WriteLine(namedTuple);
            //var first = 1;
            //var second = "Two";
            //var third = 3.0;
            //var tuple = (first, second, third);
            //Console.WriteLine(tuple);
            //(int, (int, int)) nestedTuple = (1, (2, 3));
            //Console.WriteLine(nestedTuple == (1, (2, 3)));

            //Console.WriteLine(typeof(int?));
            //var f = new DelegateF(F);
            //f += new DelegateF(F1);
            //f("C#");

            //int? i = 0;
            //Console.WriteLine(i.HasValue);
            //if (i is int a)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("no value");
            //}

            //var type = typeof(Dictionary<,>);
            //if (type.IsGenericTypeDefinition)
            //{
            //    foreach (var t in type.GetGenericArguments())
            //    {
            //        Console.WriteLine(t);
            //        Console.WriteLine(t.DeclaringType);
            //        Console.WriteLine(t.GenericParameterPosition);
            //    }
            //}

            //object o = new List<int>() { 0, 1, 2, 3, 4 };
            //var lst = o as IEnumerable;
            //foreach (var i in lst)
            //{
            //    Console.WriteLine(i);
            //}
            //var type = lst.GetType();
            //Console.WriteLine(type);
            //if (type.IsGenericType)
            //{
            //    foreach (var t in type.GetGenericArguments())
            //    {
            //        Console.WriteLine(t);
            //    }
            //    //foreach (var t in type.GenericTypeArguments)
            //    //{
            //    //    Console.WriteLine(t);
            //    //}
            //    var newType = type.GetGenericTypeDefinition().MakeGenericType(new Type[] { typeof(double) });
            //    var l = Activator.CreateInstance(newType);
            //    var add = newType.GetMethod("Add");
            //    if (add != null && l != null)
            //    {
            //        Console.WriteLine(l.GetType());
            //        foreach (var t in newType.GetGenericArguments())
            //        {
            //            Console.WriteLine(t);
            //        }
            //        for (int i = 0; i < 5; i++)
            //        {
            //            add.Invoke(l, new object[] { (double)i });
            //        }
            //        foreach (var i in l as IEnumerable<double>)
            //        {
            //            Console.WriteLine("{0:F2}", i);
            //        }
            //    }
            //}

            //var type = typeof(MyClass);
            ////var typ = new MyClass(0, 1, 2).GetType();
            ////Console.WriteLine(typ == type);
            //Console.WriteLine("Assembly: " + type.Assembly);
            //Console.WriteLine("Module: " + type.Module);
            //Console.WriteLine("All modules: ");
            //foreach (var module in type.Assembly.GetModules())
            //{
            //    Console.WriteLine(module);
            //}

            //var fields = type.GetFields();
            //Console.WriteLine("GetFields:");
            //foreach (var field in fields)
            //{
            //    Console.WriteLine(field);
            //}
            //Console.WriteLine();

            //var properties = type.GetProperties();
            //Console.WriteLine("GetProperties:");
            //foreach (var property in properties)
            //{
            //    Console.WriteLine(property);
            //}
            //Console.WriteLine();

            //var members = type.GetMembers();
            //Console.WriteLine("GetMembers");
            //foreach (var member in members)
            //{
            //    Console.WriteLine(member);
            //}
            //Console.WriteLine();

            //var methods = type.GetMethods();
            //Console.WriteLine("GetMethods:");
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method);
            //}
            //Console.WriteLine();

            //MyClass cls = new MyClass(0, 1, 2);
            //cls.Print();

            //Console.WriteLine(Marshal.SizeOf(cls));

            //Dictionary<string, int> dict = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
            //foreach (var kv in dict)
            //{
            //    Console.WriteLine($"{{ {kv.Key}, {kv.Value} }}");
            //}

            //DirectoryInfo dir = new DirectoryInfo(".");
            //FileInfo[] files = dir.GetFiles();
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //Base b = new Base();
            //b.Func();
            //b = new Derived();
            //b.Func();
            //Derived d = new Derived();
            //d.Func();

            //MyColor color = MyColor.Red;
            //int c = (int)color;
            //Console.WriteLine(color);
            //Console.WriteLine(c);

            //Base b = new Base();
            //b.Func();
            //b = new Derived1();
            //b.Func();
            //b = new Derived2();
            //b.Func();

            //Student s;
            //s.id = 0;
            //s.name = "Wang Cong";
            //s.score = 100.0f;
            //Console.WriteLine(s);

            //doit();

            //int[,] arr = { { 0, 1 }, { 2, 3 } };
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(sum(new int[] { 1, 2, 3 }));
            //Console.WriteLine(sum(1, 2, 3));

            //int[,] arr = new int[2, 2]
            //{
            //    {0, 1},
            //    {2, 3}
            //};
            //Console.WriteLine($"length: {arr.Length}");
            //Console.WriteLine($"rank: {arr.Rank}");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //int[][] arr1 = new int[2][]
            //{
            //    new int[]{4, 5},
            //    new int[]{6}
            //};
            //Console.WriteLine($"length: {arr1.Length}");
            //Console.WriteLine($"rank: {arr1.Rank}");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    for (int j = 0; j < arr1[i].Length; j++)
            //    {
            //        Console.Write($"{arr1[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //    a[i] = i;
            //}
            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}

            //int? a = null;
            //Console.WriteLine(a == null);
            //int? b = 0;
            //Console.WriteLine(a ?? b);
            //int? c = 1;
            //Console.WriteLine(a ?? b ?? c);
            //int? d = null;
            //Console.WriteLine(a ?? d);
            //double? f = 1.0;
            //Console.WriteLine(a ?? f);

            //int a, b;
            //if (getVal(out a, out b))
            //    Console.WriteLine("a: {0}, b: {1}", a, b);

            //int a = 0, b = 1;
            //swap(ref a, ref b);
            //Console.WriteLine("a: {0}, b: {1}", a, b);

            //object s = "Hello World!";
            //StringReader sr = s as StringReader;
            //if (sr != null)
            //{
            //    string str = sr.ReadToEnd();
            //    Console.WriteLine(str);
            //}
            //else
            //{
            //    Console.WriteLine("failed!");
            //}

            //int i = 0;
            //Console.WriteLine(i is long);
            //Console.WriteLine(typeof(int));
            ////Console.WriteLine(&i);

            //object o = 0;
            //object o1 = o;
            //object o2 = 0;
            //if (o == o1)
            //    Console.WriteLine("same");
            //else
            //    Console.WriteLine("not same");
            //if (o == o2)
            //    Console.WriteLine("same");
            //else
            //    Console.WriteLine("not same");
            //if (o.Equals(o2))
            //    Console.WriteLine("same");
            //else
            //    Console.WriteLine("not same");

            //string s = Console.ReadLine();
            //Console.WriteLine(s);

            //int i = int.Parse("1234");
            //Console.WriteLine(i);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //string s = "10";
            //int i = Convert.ToInt32(s);
            //Console.WriteLine(i);

            //            string s = @"Hello World!
            //Hello C#!";
            //            Console.WriteLine(s);

            //string s = "Hello World!";
            //Console.WriteLine(s);
            //Console.WriteLine(s.Length);
            //foreach(char c in s)
            //{
            //    Console.WriteLine(c);
            //}
            //s = @"你好，世界！";
            //Console.WriteLine(s);
            //Console.WriteLine(s.Length);
            //foreach (char c in s)
            //{
            //    Console.WriteLine(c);
            //}

            //foreach (string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}

            //dynamic d = true;
            //Console.WriteLine(d);

            //object o;
            //o = false;
            //bool b = (bool)o;
            //Console.WriteLine("o: {0}", o);
            //Console.WriteLine("b: {0}", b);

            //Console.WriteLine("Hello World!");

            //Console.WriteLine("bool: {0}", sizeof(bool));
            //Console.WriteLine("byte: {0}", sizeof(byte));
            //Console.WriteLine("sbyte: {0}", sizeof(sbyte));
            //Console.WriteLine("char: {0}", sizeof(char));
            //Console.WriteLine("short: {0}", sizeof(short));
            //Console.WriteLine("ushort: {0}", sizeof(ushort));
            //Console.WriteLine("int: {0}", sizeof(int));
            //Console.WriteLine("uint: {0}", sizeof(uint));
            //Console.WriteLine("long: {0}", sizeof(long));
            //Console.WriteLine("ulong: {0}", sizeof(ulong));
            //Console.WriteLine("decimal: {0}", sizeof(decimal));
            //Console.WriteLine("float: {0}", sizeof(float));
            //Console.WriteLine("double: {0}", sizeof(double));
        }
    }
}
