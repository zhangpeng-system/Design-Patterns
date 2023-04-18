/// <summary>
/// ダブルチェックによる性能と効率両方とも備える
/// </summary>
public class SingletonWithDoubleCheck
{
    //ロック
    private static readonly object singletonlock = new object();
    //Lazy インスタンス
    private static SingletonWithDoubleCheck? instance = null;
    /// <summary>
    /// アクセス可能なInstanceを外に提供します。
    /// </summary>
    /// <value></value>
    public static SingletonWithDoubleCheck Instance
    {
        get
        {
            if (instance == null)
            {
                lock (singletonlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithDoubleCheck();
                    }
                }
            }
            return instance;
        }
    }
}
