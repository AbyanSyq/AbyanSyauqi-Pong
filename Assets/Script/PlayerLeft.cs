using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeft : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRb;

    public void PlayerMovement(Vector2 magnitude){
        playerRb.velocity = magnitude;
    }
    
}

