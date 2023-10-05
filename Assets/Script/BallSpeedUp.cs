using UnityEngine;

public class BallSpeedUp : MonoBehaviour
{
    [SerializeField] float ballSpeed;
    
    private void OnTriggerEnter2D(Collider2D Ball) {
        if(Ball.tag == "Ball"){

            FindAnyObjectByType<BallMov>().SpeedUp(ballSpeed);
            FindAnyObjectByType<PowerManager>().RemovePowerUp(gameObject);
        }
        else{
            Debug.Log("trow");
            FindAnyObjectByType<PowerManager>().RemovePowerUp(gameObject);
        }
    }
}
