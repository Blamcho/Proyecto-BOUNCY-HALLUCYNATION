using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupsvelocidad  : MonoBehaviour
{
    public bool distroyautomatic;
    public movecontroller move;
    public Jump jump;
    public float speed = 5f;
    [SerializeField] private movecontroller controller;
    public int type;
    private void Awake()
    {
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<movecontroller>();
        jump = GameObject.FindGameObjectWithTag("Player").GetComponent<Jump>();

    }


    private void Update()
    {

    }

    IEnumerator timepowerup()
    {
        // powerup1 = false;
        Debug.Log("se usa el contador");
        speed = 5f;
        yield return new WaitForSeconds(10);
        speed *= Time.deltaTime;
        speed = 10;
        //powerup1 = true;
    }
    public void Efect()
    {
        switch (type)
        {
            case 1:
                move.velociti -= 5;
                break;

            default:
                Debug.Log("sin efecto");
                break;
        }
    }
}
