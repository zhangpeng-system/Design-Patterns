/// <summary>
/// Singletonクラス
/// </summary>
public class Singleton
{
    // インスタンス
    private static readonly Singleton instance = new Singleton();
    /// <summary>
    /// アクセス可能なInstanceを外に提供します。
    /// </summary>
    /// <value></value>
    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }
}
