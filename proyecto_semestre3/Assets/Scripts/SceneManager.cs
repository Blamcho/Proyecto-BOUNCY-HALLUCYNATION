using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneManager : MonoBehaviour

{
    public void StartGame()
    {
        UnitySceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Game Close");


    }

}
