
using System.Collections.Generic;
using UnityEngine;

public class PowerManager : MonoBehaviour
{   
    public int maxPowerUpAmount;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;

    public Transform spawnArea;

    public List<GameObject> powerUpTemplateList;
    private List<GameObject> powerUpList;

    private float timer;
    public float interval;

    private void Start() {
        powerUpList = new List<GameObject>();
        timer = 0;
    }
    public void Update(){
        timer += Time.deltaTime;
        if(timer >= interval){
            GenerateRandomPowerUp();
            timer = 0;
        }
    }


    public void GenerateRandomPowerUp(){
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x,powerUpAreaMax.x),Random.Range(powerUpAreaMin.y,powerUpAreaMax.y)));
    }
    public void GenerateRandomPowerUp(Vector2 position){
        if(powerUpList.Count >= maxPowerUpAmount){
            return;
        }
        int randomIndex = Random.Range(0, powerUpTemplateList.Count);
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], position, Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }
    public void RemovePowerUp(GameObject powerUp){
        
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }
    public void RemoveAllPowerUp(){
        while(powerUpList.Count > 0){
            RemovePowerUp(powerUpList[0]);
        }
    }

}
