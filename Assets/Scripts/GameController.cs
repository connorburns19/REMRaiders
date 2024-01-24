using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    float currScore = 0;
    float currHealth = 100;
    float enemiesRemaining = 10;
    float currWave = 1;
    [SerializeField] Text scoreText; 
    [SerializeField] Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        currScore = 0;
        currHealth = 100;
        currWave = 1;
        UpdateScore();
        UpdateHP();
    }

    public void AddScore(float amount)
    {
        currScore += amount;
    }

    public void UpdateScore()
    {
        scoreText.text = currScore.ToString("0");
    }
    public void AddHP(float amount)
    {
        currHealth += amount;
    }
    public void UpdateHP()
    {
        healthText.text = currHealth.ToString("0");
    }

    public void ResetEnemyCount()
    {
        enemiesRemaining = 10;
    }
    public void NextWave()
    {
        currWave++;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
