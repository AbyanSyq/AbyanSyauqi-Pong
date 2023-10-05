using UnityEngine;

public class GoalCase : MonoBehaviour
{
    [SerializeField] GameObject goalObject;
    private void OnTriggerEnter2D(Collider2D Ball) {
        if (Ball.tag == "Ball")
        {
            FindAnyObjectByType<GameManager>().resetBall();
            if (goalObject.transform.position.x <    0)
            {
                FindAnyObjectByType<GameManager>().playerLeftScore();
                Debug.Log("rigth score");
            }
            else
            {
                FindAnyObjectByType<GameManager>().playerRightScore();
            }
        }
        
    }
}
