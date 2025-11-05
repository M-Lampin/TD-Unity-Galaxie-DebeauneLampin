using System;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(
    fileName = "DestinationDataRandom",
    menuName = "Scriptable Objects/DestinationDataRandom"
)]
public class DestinationDataRandom : DestinationData
{
    [SerializeField]
    public override void SetDestination()
    {
        int currentIndex = _index;
        _index = Random.Range(0, _destinations.Length);
        Debug.Log("nouvelle position random");

        currentDestination = _destinations[_index];
    }
}
