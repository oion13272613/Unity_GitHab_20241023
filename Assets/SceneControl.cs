using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScene(string _sceneName)
    {   //�����޲z�� �� ���J����(�����W��)
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitGame()
    {   //���ε{�� �� ����
        Application.Quit();
    }
}
