using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
  [SerializeField] private Transform[] _Points = default;
  [SerializeField] private int _DestPoints = 0 ;
  [SerializeField] private NavMeshAgent _Agent;

    void Start()
    {
        _Agent = GetComponent < NavMeshAgent > ();

        _Agent.autoBraking = false;

        GotoNextpuntos();
    }
    void GotoNextpuntos()
    {
        if (_Points.Length == 0)
            return;

        _Agent.destination = _Points[_DestPoints].position;

        _DestPoints = (_DestPoints + 1) % _Points.Length;
    }

    private void Update()
    {
        if (_Agent.remainingDistance < 0.5f)
            GotoNextpuntos();
    }
}
