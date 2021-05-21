using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    //public GameObject bulletprefab;


    [Header("visuals")]
    public GameObject playercamera;
    public float ypos,xpos,zpos;
    //public GameObject spawn;
    [Header("Gameplay")]
    private int ammo;
    public int initial_ammo=47;
    public int player_health =150;
    public int Ammo { get { return ammo; } }
    public GameObject bullet_prefab;
    private AudioSource wav;
    
    




    public void Start()
    {
        ammo = initial_ammo;
        wav = GetComponent<AudioSource>();
        
        
        
        
    }





    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo > 0)
            {

                ammo--;
                 Instantiate(bullet_prefab, transform.position, transform.rotation);
                bullet_prefab.transform.rotation = playercamera.transform.rotation;
                //bullet_prefab.rb.velocity = transform.forward * 10f;
                wav.Play();


            }
            




        }
        
        }


     void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "bullet")
        {


            ammo = initial_ammo;
            Destroy(hit.gameObject);
        }
    }

}


