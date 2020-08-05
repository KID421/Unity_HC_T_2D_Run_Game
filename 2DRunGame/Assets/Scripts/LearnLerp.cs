using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    // 插值：取得兩點的中間值
    // A：0
    // B：10
    // 取得 A 與 B 中間 50 % 值
    // 插值(A，B，0.5f) = 5

    public float A = 0;
    public float B = 100;

    private void Start()
    {
        float result = Mathf.Lerp(A, B, 0.5f);
        print(result);
    }

    public float C = 0;
    public float D = 100;

    public Vector2 v2A = new Vector2(0, 0);
    public Vector2 v2B = new Vector2(100, 100);

    public Color cA = new Color(0, 0, 0);
    public Color cB = new Color(0.7f, 0.5f, 0.3f);

    private void Update()
    {
        C = Mathf.Lerp(C, D, 0.7f * Time.deltaTime);

        v2A = Vector2.Lerp(v2A, v2B, 0.7f * Time.deltaTime);

        cA = Color.Lerp(cA, cB, 0.7f * Time.deltaTime);
    }
}
