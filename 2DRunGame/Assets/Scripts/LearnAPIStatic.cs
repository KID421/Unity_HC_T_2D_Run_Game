using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
    // 認識 API 內有靜態 (Static) 關鍵字的成員
    private void Start()
    {
        // 【取得】靜態屬性 Static Properties
        // ※※※※※ 語法：
        // 類別.靜態屬性
        print(Random.value);
        print(Mathf.PI);

        // 【設定】靜態屬性 Static Properties
        // ※※※※※ 語法：
        // 類別.靜態屬性 = 值
        // ※ Read Only 不能設定 (唯讀)
        // Random.value = 0.999f; // 設定唯讀屬性會有錯誤
        // 時間速度
        Time.timeScale = 10;

        // 【使用】靜態方法 Static Method
        // ※※※※※ 語法：
        // 類別.靜態方法(對應引數)
        float r = Random.Range(100.9f, 200.5f);
        print("隨機值：" + r);

        // 整數不包含最大值
        int ri = Random.Range(1, 3);
        print("隨機整數：" + ri);

        // 練習：
        // 隱藏滑鼠 - 指標 Cursor
        Cursor.visible = false;
        // -9 取絕對值 - 數學 Mathf
        print("-9 的絕對值：" + Mathf.Abs(-9));
    }

    private void Update()
    {
        // print("遊戲時間：" + Time.time);

        // 是否按下任意鍵 - 輸入 Input - true/false
        print("玩家是否按任意鍵：" + Input.anyKeyDown);
    }
}
