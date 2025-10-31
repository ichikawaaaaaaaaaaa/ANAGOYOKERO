using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GoToGameOverScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameOverScene"); // Å© ÉVÅ[ÉìñºÇéwíË
    }
}