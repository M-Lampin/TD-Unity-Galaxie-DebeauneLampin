using System;
using UnityEngine;

[CreateAssetMenu(
    fileName = "DestinationDataPatroll",
    menuName = "Scriptable Objects/DestinationDataPatroll"
)]
public class DestinationDataPatroll : DestinationData
{
    [SerializeField]
    public override void SetDestination()
    {
        Debug.Log("set la suite");
        _index++;
        if (_index >= _destinations.Length)
        {
            if (_isLooping)
            {
                _index = 0;
            }
            else
            {
                _index = _destinations.Length - 1;
            }
        }

        currentDestination = _destinations[_index];
    }
}
