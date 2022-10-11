using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float _velocity = 10f;

    public float Velocity => _velocity;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.back * _velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.forward * _velocity * Time.deltaTime;
        }
    }

    public void ChangeVelocity(float newVelocity)
    {
        _velocity = newVelocity;
    }
}
