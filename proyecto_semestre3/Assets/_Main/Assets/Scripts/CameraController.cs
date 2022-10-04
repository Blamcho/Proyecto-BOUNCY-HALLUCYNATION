using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]  private GameObject _Player;
    private Vector3 _Position;
    void Start()
    {
        _Position = transform.position - _Player.transform.position;
    }

    void Update()
    {
        transform.position = _Player.transform.position + _Position;
    }
}
