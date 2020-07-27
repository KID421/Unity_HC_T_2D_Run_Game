using UnityEngine;

public class LearnEventMethod : MonoBehaviour
{
    // 事件：在特定時間點自動執行
    // 開始：播放遊戲後執行一次，初始化，例如：恢復血量為全滿
    // 輸出：print("訊息") - 將訊息輸出到儀表板
    private void Start()
    {
        print("哈囉，沃德~");

        // 呼叫方法
        // 語法：方法名稱();
        Test();
        Test();

        ShootFire();

        // 呼叫有參數的方法時要輸入對應的引數
        Test2(999);
        Test2(123456);

        Shoot("電");
        Shoot("土");

        // 有預設值的參數可以不填寫
        Drive(125, "右邊");
        Drive(999);

        // 多個預設值參數時可以用 參數名稱: 指定
        Drive(777,sound: "繃繃");
    }

    // 更新：一秒執行約 60 次，持續執行，例如：移動、監聽玩家輸入
    private void Update()
    {
        print("嗨，我在更新 :P");
    }

    // 方法：
    // ※※※※※ 語法
    // 修飾詞 傳回類型 方法名稱 (參數) { 程式內容 }
    // 無傳回 void
    // 方法名稱：Unity 習慣會用大寫開頭
    // 事件與方法差異：事件名稱為藍色，方法為白色
    // 事件與方法差異：事件會自動執行，方法不會，需要呼叫
    public void Test()
    {
        print("測試!!!");
    }

    // RPG：施放火球
    public void ShootFire()
    {
        print("施放火球!!!");
        print("執行動畫");
    }
    public void ShootIce()
    {
        print("施放冰球!!!");
        print("執行動畫");
    }
    public void ShootWater()
    {
        print("施放水球!!!");
        print("執行動畫");
    }

    /// <summary>
    /// 施放技能
    /// </summary>
    /// <param name="prop">屬性</param>
    public void Shoot(string prop)
    {
        print("施放" + prop + "球!!!");
        print("執行動畫");
    }

    // 參數語法：(參數類型 參數名稱，參數類型 參數名稱，..................)
    // 參數與欄位相同但不需要修飾詞
    public void Test2(int number)
    {
        print("我是測試 2 號，您所輸入的數字為");
        print(number);
    }

    // 參數預設值：選填式參數
    // 語法：類型 名稱 = 值
    // 有預設值得參數必須寫在最右邊
    public void Drive(int speed, string direction = "前方", string sound = "咻咻")
    {
        print("時速：" + speed);
        print("開車方向：" + direction);
        print("開車音效：" + sound);
    }
}
