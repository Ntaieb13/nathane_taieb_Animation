using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private NavMeshAgent _agent;
    private Animator _animator;


    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_target.transform.position);
        _animator = GetComponent<Animator>();  
    }
    private void Update()
    {
        _animator.SetFloat("Speed", _agent.velocity.magnitude);

    }
    
}
