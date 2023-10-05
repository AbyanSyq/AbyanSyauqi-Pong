using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float ballSpeedX;
    [SerializeField] float playerRightDirection;
    [SerializeField] float playerLeftDirection;
    [SerializeField] float playerMovSpeed;
    [SerializeField] float ballMaxSpeed;

    private bool playing;

    private int rightScore;
    private int leftScore;
    private void Start() {
        playing = false;
        rightScore = 0;
        leftScore = 0;
    }
    private void FixedUpdate() {
        playerMov();
        
    }
    private void Update() {
        input();
        ballSpeedLimit();
        GameOver();
        // Debug.Log(playerRightDirection+""+playerLeftDirection);
    }
    public void input(){
        if (Input.GetKeyDown(KeyCode.Space) && playing == false)//game di mulai
        {
            FindAnyObjectByType<BallMov>().movement(ballMovDirection());//Gerakan bola di awal permainan
            playing = true;
        }
        playerRightDirection = Input.GetAxisRaw("VerticalRight");
        playerLeftDirection = Input.GetAxisRaw("VerticalLeft");

    }

    //====================Ball Movement===============
    public Vector2 ballMovDirection(){
        float randomY = Random.Range(-6,6);
        return new Vector2(ballSpeedX,randomY);
    }
    public void ballSpeedLimit(){
        FindAnyObjectByType<BallMov>().maxSpeed(ballMaxSpeed);
    }
    //====================Player Movement===============
    public void playerMov(){
        FindAnyObjectByType<PlayerRight>().PlayerMovement(new Vector2(0,playerMovSpeed*playerRightDirection));
        FindAnyObjectByType<PlayerLeft>().PlayerMovement(new Vector2(0,playerMovSpeed*playerLeftDirection));

    }
    //====================Finish condition===============
    public void resetBall(){
        FindAnyObjectByType<BallMov>().resetBall();
        playing = false;
    }
    public void GameOver(){
        if (rightScore == 3|| leftScore == 3)
        {
            rightScore = 0;
            leftScore  = 0;
            FindAnyObjectByType<ScoreManager>().RightScore(rightScore);
            FindAnyObjectByType<ScoreManager>().LeftScore(leftScore);
            menu(); 
        }
    }
    //====================Score==================
    public void playerRightScore(){
        rightScore++;
        FindAnyObjectByType<ScoreManager>().RightScore(rightScore);
    }
    public void playerLeftScore(){
        leftScore++;  
        FindAnyObjectByType<ScoreManager>().LeftScore(leftScore);
    }
    //===================Scene===================
    public void menu(){
        SceneManager.LoadScene(0);
    }

    
    




}
