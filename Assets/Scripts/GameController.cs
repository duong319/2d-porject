using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public float spawntime;
    int Score;
    float Spawntime;
    bool isGameOver;
    void Start()
    {
        Spawntime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            Spawntime = 0;
            return;
        }
        Spawntime -= Time.deltaTime;

        if (Spawntime <= 0)
        {
            SpawnObstacle();
            Spawntime = spawntime;
        }
    }

    public void SpawnObstacle()
    {
        float randYpos1 = Random.Range(-7f, -2.85f);
        float randYpos2 = Random.Range(3f, 6.5f);
       
        Vector2 spawnPos1 = new Vector2(9, randYpos1);
        Vector2 spawnPos2 = new Vector2(9, randYpos2);
       

        if (obstacle1)
        {
            Instantiate(obstacle1, spawnPos1, Quaternion.identity);
        }
        if (obstacle2)
        {
            Instantiate(obstacle2 , spawnPos2, Quaternion.identity);
        }
    }
    public void SetScore(int value)
    {
        Score = value;
    }
    public int GetScore()
    {
        return Score;
    }
    public void ScoreInCrement()
    {
        Score++;
    }
    public bool IsGameOver()
    {
        return isGameOver;
    }
    public void SetGameOverState(bool state)
    {
        isGameOver = state;
    }
}
