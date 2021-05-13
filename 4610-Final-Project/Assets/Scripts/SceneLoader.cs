using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Canvas heathCanvas;
    [SerializeField] Canvas gameStartCanvas;
    [SerializeField] Canvas gameOverCanvas;

    // Start is called before the first frame update
    public void StartGame()
    {
        heathCanvas.enabled = true;
        gameStartCanvas.enabled = false;
        gameOverCanvas.enabled = false;
        Time.timeScale = 1;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
        heathCanvas.enabled = true;
        gameStartCanvas.enabled = false;
        gameOverCanvas.enabled = false;
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        // Debug.Log("Quit");
        Application.Quit();
    }
}
