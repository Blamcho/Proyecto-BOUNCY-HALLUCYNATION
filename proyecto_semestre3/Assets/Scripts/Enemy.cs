using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Transform cameraObject = collision.transform.GetChild(0);
            cameraObject.parent = null;
            Destroy(collision.gameObject);
        }
    }
}
