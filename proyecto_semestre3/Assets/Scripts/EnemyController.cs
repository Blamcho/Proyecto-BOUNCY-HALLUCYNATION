using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] _puntos;
    private int destpuntos = 0;
    public NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.autoBraking = false;
        GotoNextpuntos();
    }

    void GotoNextpuntos()
    {
        if (_puntos.Length == 0)
            return;
        _agent.destination = _puntos[destpuntos].position;
        destpuntos = (destpuntos + 1) % _puntos.Length;
    }

    private void Update()
    {
        if (_agent.remainingDistance < 0.5f)
            GotoNextpuntos();
    }

}

