using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DestinationData", menuName = "Scriptable Objects/DestinationData")]
public class DestinationData : ScriptableObject
{
    public Vector3 currentDestination;

    [SerializeField]
    private Vector3[] _destinations = null;

    [SerializeField]
    private int _index = 0;

    [SerializeField]
    bool _isLooping = false;

    [SerializeField]
    public void SetDestination()
    {
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

    [SerializeField]
    public Vector3[] GetDestinations() => _destinations;
}
