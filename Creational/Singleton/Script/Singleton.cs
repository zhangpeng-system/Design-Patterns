/// <summary>
/// Singletonクラス
/// </summary>
public class Singleton
{
    // 唯一のインスタンスを生成
    private static readonly Singleton instance = new Singleton();

    /// <summary>
    /// 外部からアクセス可能なInstanceを提供
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
