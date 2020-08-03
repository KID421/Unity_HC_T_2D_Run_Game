using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;
    [Header("跳越高度"), Range(0, 1000)]
    public int jump = 350;
    [Header("血量"), Range(0, 2000)]
    public float hp = 500;

    public bool isGround;
    public int coin;

    [Header("音效區域")]
    public AudioClip soundHit;
    public AudioClip soundSlide;
    public AudioClip soundJump;
    public AudioClip soundCoin;

    public Animator ani;
    public Rigidbody2D rid;
    public CapsuleCollider2D cap;
    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {

    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        // 動畫控制器.設定布林值("參數名稱"，布林值)
        // true 玩家是否按下空白鍵
        ani.SetBool("跳躍開關", true);
    }

    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {

    }

    /// <summary>
    /// 吃金幣
    /// </summary>
    private void EatCoin()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 過關
    /// </summary>
    private void Pass()
    {

    }

    #endregion

    #region 事件
    private void Start()
    {

    }

    private void Update()
    {
        Jump();
    }
    #endregion
}
