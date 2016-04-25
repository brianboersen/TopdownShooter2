using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

    NavMeshAgent _navmeshagent;
    GameObject _playergameobject;
    void Awake()
    {
        _navmeshagent = GetComponent<NavMeshAgent>();
        _playergameobject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        _navmeshagent.SetDestination(_playergameobject.transform.position);
    }
}
