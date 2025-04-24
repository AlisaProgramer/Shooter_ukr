using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Assign the player's transform in the inspector
    public float startDistance = 10f; // Distance at which the enemy starts following the player
    public float stopDistance = 15f; // Distance at which the enemy stops following the player
    public float patrolRadius = 20f; // Radius within which the enemy patrols
    public float minDistance = 0.5f;
    public Animator animator;
    private NavMeshAgent agent;
    private Vector3 patrolCenter;
    private bool isFollowing = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        patrolCenter = transform.position;
        Patrol();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
       
        if (isFollowing)
        {
            if (agent.remainingDistance < minDistance)
            {
                animator.SetBool("walk", false);
            }
            else
            {
                animator.SetBool("walk", true);
            }
            if (distanceToPlayer > stopDistance)
            {
                isFollowing = false;
                Patrol();
            }
            else
            {
                FollowPlayer();
            }
        }
        else
        {
            if (distanceToPlayer < startDistance)
            {
                isFollowing = true;
            }
            else
            {
                if (!agent.pathPending && agent.remainingDistance < minDistance)
                {
                    Patrol();
                }
            }
        }
    }

    void FollowPlayer()
    {
        agent.SetDestination(player.position);
    }

    void Patrol()
    {
        Vector3 randomDirection = Random.insideUnitSphere * patrolRadius;
        randomDirection += patrolCenter;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, patrolRadius, -1);

        agent.SetDestination(navHit.position);
    }

    void OnDrawGizmosSelected()
    {
        // Draw the patrol radius in the editor for visualization
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(patrolCenter, patrolRadius);

        // Draw the start and stop distances for the player detection
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, startDistance);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, stopDistance);
    }
}
