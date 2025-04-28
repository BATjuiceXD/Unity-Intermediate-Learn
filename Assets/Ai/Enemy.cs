using UnityEngine;
using UnityEngine.AI;

public class Enemy : Character
{
    public Transform[] ObserveLocation => _observeLocation;
    [SerializeField] private Transform[] _observeLocation;
    [SerializeField] private NavMeshAgent _agent;

    private State _currentState;

    private void Start()
    {
        _currentState = new Roaming(this, _agent);

        PlayerController.Instance.TakeDamage(_atkdamage);
    }
    private void Update()
    {
        _currentState = _currentState.Process();
    }
}
