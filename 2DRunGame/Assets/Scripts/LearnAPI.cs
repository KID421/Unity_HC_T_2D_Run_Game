using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // 【非靜態】成員需要
    // 1. 實體物件或元件 (Unity 階層面板)
    // 2. 欄位
    // 先看場景上有的物件與元件
    public GameObject sphere;

    public Transform tra;

    public Transform cube;

    public Light myLight;

    public Camera cam;

    private void Start()
    {
        // 【取得】屬性 Peoperties
        // ※※※※※ 語法：
        // 欄位名稱.屬性
        print(sphere.layer);

        print("球的座標：" + tra.position);

        // 【設定】屬性 Peoperties
        // ※※※※※ 語法：
        // 欄位名稱.屬性 = 值
        tra.localScale = new Vector3(7, 7, 7);

        // 練習：
        // 1. 控制燈光顏色為紅色 Light
        //myLight.color = Color.red;
        myLight.color = new Color(0.8f, 0, 0);
        // 2. 設定燈光恢復預設值 Light
        myLight.Reset();
        // 3. 調整攝影機的尺寸 3 Camera
        cam.orthographicSize = 3;
    }

    private void Update()
    {
        // 【使用】方法 Methofs
        // ※※※※※ 語法：
        // 欄位名稱.方法(對應的引數)
        cube.Rotate(0, 0, 10);
        cube.Translate(1, 0, 0);
    }
}
