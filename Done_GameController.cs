
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
    public GameObject[] hazards;

    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
   

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public Text HyperText;

    private bool gameOver;
    private bool restart;
    public static int score;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        HyperText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
        
    }

    void Update() {
        if (Input.GetKey("escape"))
            Application.Quit();
       


        if (score >= 100)
        {
            gameOverText.text = "Game Created by Jonathon Bridges";
            HyperText.text = "Hyperdrive Activated!";
            gameOver = true;
     
        }
       
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'Y' for Restart";
                restart = true;
                break;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {    
            score += newScoreValue;
            UpdateScore();

           
        
       
    }

    void UpdateScore()
    {
        scoreText.text = "Speed: " + score + "%";
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

    
}