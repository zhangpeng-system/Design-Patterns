/// <summary>
/// Singletonクラス(Lazy＆DoubleCheck)
/// </summary>
public class LazySingleton
{
    //ロック
    private static readonly object singletonlock = new object();
    //Lazy インスタンス
    private static LazySingleton? instance = null;
    /// <summary>
    /// アクセス可能なInstanceを外に提供します。
    /// </summary>
    /// <value></value>
    public static LazySingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (singletonlock)
                {
                    if (instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }
    }
}
