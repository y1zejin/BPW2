using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToScene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Changed scene to " + sceneName);
    }

    public void ExitGame()
    {
        Debug.Log("exit game");
        Application.Quit();
    }
}
