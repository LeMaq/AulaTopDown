using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;
    private int playerLife;
    public GameObject gameOverCanvas;
    

    private void Update()
    {
        playerLife = player.GetComponent<PlayerLife>().GetCurrentLife();

        if (playerLife <= 0)
        {
            gameOverCanvas.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
