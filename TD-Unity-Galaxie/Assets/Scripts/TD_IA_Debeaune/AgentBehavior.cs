using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehavior : MonoBehaviour
{
    [SerializeField]
    DestinationData _destinationData;

    private NavMeshAgent _navMeshAgent = null;

    private bool _canSelectDestination = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _destinationData.SetDestination();
    }

    // Update is called once per frame
    void Update()
    {
        _navMeshAgent.destination = _destinationData.currentDestination;

        if (
            _navMeshAgent.remainingDistance < _navMeshAgent.stoppingDistance
            && _canSelectDestination
        )
        {
            _destinationData.SetDestination();
            _canSelectDestination = false;
            StartCoroutine(DelayDestinationActivation());
        }
    }

    private IEnumerator DelayDestinationActivation()
    {
        yield return new WaitForSeconds(0.1f);
        _canSelectDestination = true;
    }

    void OnDrawGizmosSelected()
    {
        var destinations = _destinationData.GetDestinations();
        for (int i = 0; i < destinations.Length; i++)
        {
            Gizmos.DrawCube(destinations[i], Vector3.one * 0.5f);
            Debug.DrawLine(destinations[i], destinations[(i + 1) % destinations.Length], Color.red);
        }
    }
}
