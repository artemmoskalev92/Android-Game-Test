using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject restartButton;

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUp()
    {
        score++;
        if (score >= 6 )
        {
            Win();
        }
    }
    void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
