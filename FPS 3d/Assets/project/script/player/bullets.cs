using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float lifetime = 0.5f;
    private float lifetimer;
    public int health = 50;
    public int damage = 10;
    //public GameObject enemy_prefab;


    public float speed;
    private void OnEnable()
    {
        lifetimer = lifetime;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifetimer -= Time.deltaTime;
        if (lifetimer <= 0f)
        {
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
        
    }
    /*private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Respawn")
        {
            health -= 10;
            if (health <= 0)
            {
                Destroy(enemy_prefab);
            }
        }


    }*/
}
