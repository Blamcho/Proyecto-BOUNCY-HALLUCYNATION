using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            UnitySceneManager.LoadScene(3);
        }
    }

}
