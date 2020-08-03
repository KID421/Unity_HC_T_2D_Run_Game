using UnityEngine;
using UnityEngine.SceneManagement;  // 引用 場景管理 API

public class SceneControl : MonoBehaviour
{
    // 方法要被按鈕呼叫需要設為公開 public

    /// <summary>
    /// 切換場景
    /// </summary>
    private void ChangeScene()
    {
        // 切換場景
        // 場景管理.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲場景");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    private void Quit()
    {
        // 關閉遊戲並離開
        // 應用程式.離開
        Application.Quit();
    }

    // 延遲呼叫方法 Invoke("方法名稱"，延遲秒數)
    /// <summary>
    /// 延遲切換場景
    /// </summary>
    public void DelayChangeScene()
    {
        Invoke("ChangeScene", 0.7f);
    }

    /// <summary>
    /// 延遲離開遊戲
    /// </summary>
    public void DelayQuit()
    {
        Invoke("Quit", 0.7f);
    }
}
