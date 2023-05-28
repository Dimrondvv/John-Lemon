using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform Player;
    public UnityEngine.AI.NavMeshAgent enemy;

    Rigidbody rig;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // enemy move toward player
        enemy.SetDestination(Player.position);
        enemy.speed = 1f;
    }
}
