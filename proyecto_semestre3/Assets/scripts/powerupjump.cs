using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class powerupjump : MonoBehaviour
{
    public bool Tookpowerup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("powerup"))

        {
            Tookpowerup = true;
            Destroy (other.gameObject);
        }
    }

}
