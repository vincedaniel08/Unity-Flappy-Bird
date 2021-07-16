using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
   public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        SoundManager.BirdDeath();
        



    }

    public  void Replay()
    {

        SceneManager.LoadScene(0);
    }
}
