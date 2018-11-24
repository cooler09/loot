using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int Health = 100;
    Transform player;
    //PlayerHealth playerHealth;
    //EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        //enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {
        //if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
        nav.SetDestination(player.position);
        //}
        //else
        //{
        //    nav.enabled = false;
        //}
		if(Health <= 0)
        {
            Destroy(gameObject);
        }
	}
    void OnColliderEnter(Collider col)
    {
        if (col.gameObject.name == "missle")
        {
            Health -= 10;
        }
    }
}
