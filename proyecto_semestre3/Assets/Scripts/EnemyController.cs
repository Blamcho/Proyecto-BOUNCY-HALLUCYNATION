using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] puntos;
    private int destpuntos = 0 ;
    public  NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent < NavMeshAgent > ();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextpuntos();
    }

    void GotoNextpuntos()
    {
        // Returns if no points have been set up
        if (puntos.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = puntos[destpuntos].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destpuntos = (destpuntos + 1) % puntos.Length;
    }

    private void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (agent.remainingDistance < 0.5f)
            GotoNextpuntos();
    }




}
