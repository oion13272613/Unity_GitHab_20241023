using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScene(string _sceneName)
    {   //場景管理器 的 載入場景(場景名稱)
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitGame()
    {   //應用程式 的 結束
        Application.Quit();
    }
}
