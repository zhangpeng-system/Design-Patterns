public class program
{
    static void Main(string[] args)
    {
        SingletonTest();
        SingletonWithDoubleCheckTest();


        void SingletonTest()
        {
            Singleton? Singleton1 = null;
            Singleton? Singleton2 = null;

            Task.Run(() =>
            {
                Singleton1 = Singleton.Instance;
            });
            Task.Run(() =>
            {
                Singleton2 = Singleton.Instance;
            });

            Thread.Sleep(2000);

            if (Singleton2 is not null)
            {
                Console.WriteLine(Singleton2.Equals(Singleton1));
            }

        }
        
        void SingletonWithDoubleCheckTest()
        {
            SingletonWithDoubleCheck? singletonDoubleCheck1 = null;
            SingletonWithDoubleCheck? singletonDoubleCheck2 = null;

            Task.Run(() =>
            {
                singletonDoubleCheck1 = SingletonWithDoubleCheck.Instance;
            });
            Task.Run(() =>
            {
                singletonDoubleCheck2 = SingletonWithDoubleCheck.Instance;
            });

            Thread.Sleep(2000);

            if (singletonDoubleCheck2 is not null)
            {
                Console.WriteLine(singletonDoubleCheck2.Equals(singletonDoubleCheck1));
            }

        }
    }
}