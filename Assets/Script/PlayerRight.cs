
using UnityEngine;

public class PlayerRight : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRb;

    public void PlayerMovement(Vector2 magnitude){
        playerRb.velocity = magnitude;
    }
}
