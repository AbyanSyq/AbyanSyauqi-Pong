
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text rightScore;
    [SerializeField] Text leftScore;
    public void RightScore(int magnitude){
        rightScore.text= magnitude.ToString("00");  
    }
    public void LeftScore(int magnitude){
        leftScore.text= magnitude.ToString("00");     
    }
    
}
