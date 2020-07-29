using UnityEngine;

public class LearnMethodReturn : MonoBehaviour
{
    // 開始事件：播放時執行一次
    private void Start()
    {
        Method();           // 無傳回 不會得到資料

        // 區域變數 『類型 名稱』
        // 僅限於此大括號內使用
        int a = Ten();      // 傳回 會得到傳回類型資料
        print(a);

        string n = Name();  // 儲存於區域變數
        print(n);

        print(Speed());     // 也可直接使用傳回方法

        print("補血：" + HpAdd(99));
    }

    // 方法語法：
    // 修飾詞 傳回類型 方法名稱(參數) { 程式內容 }
    public void Method()
    {
        print("一般方法");
    }

    // 公開 傳回整數 十
    public int Ten()
    {
        // 傳回 10
        return 10;
    }

    public string Name()
    {
        return "KID";
    }

    public float Speed()
    {
        return 1.5f;
    }

    // 遊戲應用：補血後傳回補完後的血量
    public float HpAdd(float hp)
    {
        hp += 10;
        return hp;
    }
}
