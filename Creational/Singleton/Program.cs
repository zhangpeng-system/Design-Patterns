public class program
{
    static void Main(string[] args)
    {
        SingletonWithDoubleCheck singletonDoubleCheck1 = SingletonWithDoubleCheck.Instance;
        SingletonWithDoubleCheck singletonDoubleCheck2 = SingletonWithDoubleCheck.Instance;
        Thread.Sleep(2000);
        Console.WriteLine(singletonDoubleCheck2.Equals(singletonDoubleCheck1));
    }
}