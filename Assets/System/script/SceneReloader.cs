using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    // 入力がない場合にリセットする時間（秒）
    private float resetTime = 210f; // 3分30秒 = 210秒
    // 最後の入力時間
    private float lastInputTime;

    void Start()
    {
        // 初期化時に最後の入力時間を現在の時間に設定
        lastInputTime = Time.time;
    }

    void Update()
    {
        // 任意のキー入力を検出
        if (Input.anyKey)
        {
            lastInputTime = Time.time;
        }

        // 最後の入力から設定した時間が経過したかチェック
        if (Time.time - lastInputTime > resetTime)
        {
            // 現在のシーンをリロード
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
