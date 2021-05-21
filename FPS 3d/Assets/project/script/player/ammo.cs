using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    private AudioSource wav;
    public player player2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" )
        {
            player2.Start();
            wav.Play();
        }
        
    }
    private void Start()
    {
        wav = GetComponent<AudioSource>();
    }
}
