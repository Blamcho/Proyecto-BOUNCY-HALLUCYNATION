using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageobjet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
