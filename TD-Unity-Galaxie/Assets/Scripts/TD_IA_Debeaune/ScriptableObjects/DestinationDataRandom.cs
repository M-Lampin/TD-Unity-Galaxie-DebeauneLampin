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
        Debug.Log("nouvelle position random");
        int currentIndex = _index;

        while (_index == currentIndex)
        {
            _index = Random.Range(0, _destinations.Length);
        }

        currentDestination = _destinations[_index];
    }
}
