using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_controller : MonoBehaviour
{

    [Header("Game")]
    public player player1;
   
    [Header("Interface")]
    public Text ammo_text;
    public Text health;
  

    // Update is called once per frame
    void Update()
    {
        ammo_text.text =  System.Convert.ToString(player1.Ammo) + "/12";
        health.text = System.Convert.ToString(player1.player_health);

    }
}
