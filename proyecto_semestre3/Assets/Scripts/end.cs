using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class end : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
         if (collision.gameObject.tag == "Player")
         {
            UnitySceneManager.LoadScene(2);
         }
    }
}