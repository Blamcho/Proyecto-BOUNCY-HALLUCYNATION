using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] puntos;
    private int destpuntos = 0 ;
    public  NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent < NavMeshAgent > ();
        agent.autoBraking = false;
        GotoNextpuntos();
    }

    void GotoNextpuntos()
    {
        if (puntos.Length == 0)
            return;
        agent.destination = puntos[destpuntos].position;
        destpuntos = (destpuntos + 1) % puntos.Length;
    }

    private void Update()
    {
        if (agent.remainingDistance < 0.5f)
            GotoNextpuntos();
    }

}
