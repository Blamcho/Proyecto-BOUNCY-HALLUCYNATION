using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontroller : MonoBehaviour
{

    public float velociti = 10f;
    public float speed = 5f;
    public GameObject Box;
    public GameObject Box2;
    public movecontroller move;
    public Jump jump;    
    public int tipe;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))

        {
            transform.position += Vector3.back * velociti * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))

        {
            transform.position += Vector3.forward * velociti * Time.deltaTime;

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<powerupsvelocidad>().Efect();
        Destroy(Box);

        other.GetComponent<powerupsvelocidad>().Efect();
        Destroy(Box2);
    }

}

 




