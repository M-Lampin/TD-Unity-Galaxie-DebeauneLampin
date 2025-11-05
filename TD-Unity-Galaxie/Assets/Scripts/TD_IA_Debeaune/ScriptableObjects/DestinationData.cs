using System;
using UnityEngine;

[CreateAssetMenu(
    fileName = "DestinationDataPatroll",
    menuName = "Scriptable Objects/DestinationDataPatroll"
)]
public abstract class DestinationData : ScriptableObject
{
    public Vector3 currentDestination;

    [SerializeField]
    protected Vector3[] _destinations = null;

    [SerializeField]
    protected int _index = 0;

    [SerializeField]
    protected bool _isLooping = false;

    [SerializeField]
    public abstract void SetDestination();

    [SerializeField]
    public Vector3[] GetDestinations() => _destinations;
}
