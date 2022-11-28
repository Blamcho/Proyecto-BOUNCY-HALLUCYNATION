using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class GameOver : MonoBehaviour
{
    /*
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UnitySceneManager.LoadScene(3);
        }

    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            UnitySceneManager.LoadScene(3);
        }
    }
}
