using UnityEngine;

public class Car : MonoBehaviour
{
    // 欄位 field：儲存資料
    // ※※※※※ 欄位語法
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束符號
    // ※ 欄位值以 Unity 屬性 (Inspector) 面板為主

    // 整數 int：沒有小數點的數值，例：1、100、-999
    // 浮點數 float：有小數點的數值，例：1.234、-999.9       - 結尾必須要有 f 大小寫皆可
    // 字串 string：文字，例：紅水、kid@gmail.com、3213salkj - 必須包覆在 "" 內
    // 布林值 bool：是、否，例：true、false

    // 修飾詞：預設為私人
    // 私人 private：不顯示
    // 公開 public ：顯示

    // 資料
    // 品牌、CC 數、重量、是否有天窗、速度、顏色
    // 欄位的屬性
    // 語法：[屬性名稱(值)]
    // 標題 Header("標題")
    // 提示 Tooltip("提示文字")
    // 範圍 Range(最小值，最大值) - 僅限於數值類型
    [Header("品牌")]
    public string brand = "賓士";
    [Header("CC 數"), Tooltip("汽車的 CC 數量")]
    public int cc = 1500;
    [Header("重量"), Range(0, 100)]
    public float weight = 20.5f;
    [Header("是否有天窗"), Tooltip("打勾代表有，取消代表沒有")]
    public bool window = true;
    [Header("速度"), Range(0, 200)]
    public float speed = 60.5f;

    // 補充：Unity 常用資料類型
    // 顏色、座標(2、3、4)
    // Color、Vector234
    public Color red = Color.red;
    public Color myColor = new Color(0.5f, 0.5f, 0.9f);

    public Vector2 posZero = Vector2.zero;
    public Vector2 posOne = Vector2.one;
    public Vector2 posCustom = new Vector2(9, 20);

    public Vector3 pos3 = new Vector3(3, 2, 1);

    public Vector4 pos4 = new Vector4(1, 2, 3, 4);

    // 儲存物件、元件
    // 物件：階層 (Hierarchy) 面板內的所有東西
    // 元件：屬性 (Inspector) 面板內的粗體字 > Class
    public GameObject cam;
    public Transform traCam;
    public Camera cam1;
}
