using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target; // El objeto que el enemigo persigue (usualmente el jugador)
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (target == null)
        {
            Debug.LogError("No se ha asignado un objetivo para el enemigo.");
        }
        else
        {
            // Iniciar la persecución al objetivo
            navMeshAgent.SetDestination(target.position);
        }
    }

    void Update()
    {
        // Si el objetivo se mueve, actualizar el destino del enemigo
        if (target != null && navMeshAgent.destination != target.position)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}
