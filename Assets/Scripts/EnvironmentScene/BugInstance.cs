using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class BugInstance : MonoBehaviour
{
    public BugSO baseBug;
    public float size;
    public float weight;
    public float value;

    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    public int m_CurrentWaypointIndex;

    private Rigidbody rb;
    private Animator animator;
    private bool isWaiting = false;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (!isWaiting)
        {
            HandleMovement();
            HandleAnimations();
        }
        else
        {
            animator.SetFloat("Speed", 0f); // Ensure bug remains in idle while paused
        }
    }


    private void HandleMovement()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && !isWaiting)
        {
            StartCoroutine(WaitAtWaypoint(Random.Range(1f, 4f)));
        }
    }

    private void HandleAnimations()
    {
        float horizontalSpeed = new Vector3(navMeshAgent.velocity.x, 0, navMeshAgent.velocity.z).magnitude;
        animator.SetFloat("Speed", horizontalSpeed);

        // Jump logic if bug can jump
        if (baseBug.GetJump() && horizontalSpeed > 0.1f && Random.value < 0.002f)
        {
            animator.SetTrigger("Jump");
        }
    }

    private IEnumerator WaitAtWaypoint(float waitTime)
    {
        isWaiting = true;

        // Stop NavMeshAgent and clear velocity
        navMeshAgent.isStopped = true;
        navMeshAgent.velocity = Vector3.zero; // important for animation logic
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
        }

        // Force idle animation
        animator.SetFloat("Speed", 0f);

        yield return new WaitForSeconds(waitTime);

        // Resume to next waypoint
        m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
        if(m_CurrentWaypointIndex == 0)
        {
            Destroy(gameObject);
        }
        navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        navMeshAgent.isStopped = false;

        isWaiting = false;
    }


    public void InitializeBug(BugSO bugSO)
    {
        baseBug = bugSO;

        // Randomize size & weight
        size = Random.Range(bugSO.GetMinSize(), bugSO.GetMaxSize());
        weight = Mathf.Lerp(bugSO.GetMinWeight(), bugSO.GetMaxWeight(),
                            Mathf.InverseLerp(bugSO.GetMinSize(), bugSO.GetMaxSize(), size));
        size = (float)System.Math.Round(size, 2);
        weight = (float)System.Math.Round(weight, 2);
        value = size * weight;
        

        // Apply physics properties
        if (rb != null) rb.mass = weight;
        //transform.localScale *= size;

        // Start NavMesh movement
        if (waypoints != null && waypoints.Length > 0)
        {
            m_CurrentWaypointIndex = 0;
            navMeshAgent.SetDestination(waypoints[0].position);
        }
    }
}
