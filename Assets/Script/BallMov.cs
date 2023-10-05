using UnityEngine;

public class BallMov : MonoBehaviour
{
    private void FixedUpdate() {
        // Debug.Log(BallRb.velocity);
    }
    [SerializeField] Rigidbody2D BallRb;
    public void movement(Vector2 magnitude){//movement pertamakali || dipanggil oleh game manajer
        BallRb.velocity = magnitude;
    }
    public void maxSpeed(float magnitude){//jika kecepatan melebihi batas maka akan dikurangi kecepatanya
        if (BallRb.velocity.x > magnitude)
        {
            BallRb.velocity = new Vector2(BallRb.velocity.x -1,BallRb.velocity.y);
        } 
        else if (BallRb.velocity.x < -magnitude)
        {

            BallRb.velocity = new Vector2(BallRb.velocity.x +1,BallRb.velocity.y);
        } 
        else if (BallRb.velocity.y > magnitude)
        {

            BallRb.velocity = new Vector2(BallRb.velocity.x,BallRb.velocity.y -1);
        } 
        else if (BallRb.velocity.y < -magnitude)
        {
            
            BallRb.velocity = new Vector2(BallRb.velocity.x,BallRb.velocity.y +1);
        } 
    }
    private void OnCollisionEnter2D(Collision2D Player) {//menambah kecepatan jika menabrak player
        if (Player.collider.tag == "Player")
        {
            BallRb.velocity = new Vector2(BallRb.velocity.x * 1.2f, BallRb.velocity.y * 1.2f);
        }       
    }
    public void resetBall(){
        BallRb.position = Vector2.zero;
        BallRb.velocity = Vector2.zero;
    }
    public void SpeedUp(float magnitude){
        BallRb.velocity *= magnitude;
    }





}
