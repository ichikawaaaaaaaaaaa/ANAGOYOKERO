using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    // ���̊֐����{�^�����N���b�N�����Ƃ��ɌĂ΂�܂�
    public void RetryGame()
    {
        Debug.Log("Retry �{�^����������܂���");
        // ���݂̃V�[�����ă��[�h���܂�
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGame");
    }
}