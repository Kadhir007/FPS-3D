using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private player p;
    public int health = 20;
    public int damage = 20;
    public player p1;
    private NavMeshAgent agent;

    /* public float shoot_timer,xpos,ypos,zpos;
     public GameObject lava,spawn;
     //private bool ishurt;
     public float shoot_Interval;

     private int  time_stamp;*/


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            p1.player_health -= damage;
            if (p1.player_health <= 0)
            {
                SceneManager.LoadScene("fail");
            }
        }
        
        if (other.gameObject.tag == "Enemy")
        {
            health -= 10;
            if (health <= 0)
            {
                
                Destroy(gameObject);
                
                




               
            }
        }
        

    }
    private void Update()
    {
        agent.SetDestination(p1.transform.position);
        
    }
    
    







    /* private void Start()
     {
         p = GameObject.Find("Player").GetComponent<player>();
         shoot_timer = Random.Range(0, shoot_Interval);


         ///////////////////////////////////////
         ///



     }
     private void Update()
     {
         shoot_timer -= Time.deltaTime;
         if ((shoot_timer <= 0) && (Vector3.Distance(transform.position, p1.transform.position) < 10))
         {


             shoot_timer = shoot_Interval;
             Instantiate(lava);
             lava.transform.position = p1.transform.position-new Vector3(xpos, ypos, zpos);
             lava.transform.rotation = p1.playercamera.transform.rotation;
             lava.transform.forward = (p1.transform.position - transform.position).normalized;

         }

     }*/

}
