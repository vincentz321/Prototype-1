﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollorPlayer : MonoBehaviour
{
  public GameObject player;  
  private Vector3 offset = new Vector3(0,5,-7); 
     // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    { 
     // offset the camera behind the player by adding to the player's posltion
     transform.position = player.transform.position+ new Vector3(0,5,-7);
    }



}

