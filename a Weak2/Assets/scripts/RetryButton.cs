using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    // この関数がボタンをクリックしたときに呼ばれます
    public void RetryGame()
    {
        Debug.Log("Retry ボタンが押されました");
        // 現在のシーンを再ロードします
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGame");
    }
}