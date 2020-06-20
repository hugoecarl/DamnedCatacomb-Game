using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monsterChase : MonoBehaviour
{

    [SerializeField]
    public Transform _destination;

    NavMeshAgent _navMeshAgent;
    private Vector3 targetVector;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        targetVector = _destination.transform.position;
        _navMeshAgent.SetDestination(targetVector);

    }
    void Update()
    {
        _navMeshAgent.speed = (0.5f*GamePlay.count + 1) * 0.5f;
        targetVector = _destination.transform.position;
        _navMeshAgent.SetDestination(targetVector);
    }
}
