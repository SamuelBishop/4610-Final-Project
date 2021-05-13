using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas gameWinCanvas;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.enabled = false;
        gameWinCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // public void HandleDeath()
    // {
    //     StartCoroutine(ShowSplatter());
    // }

    // IEnumerator ShowSplatter()
    // {
    //     SceneManager.LoadScene(0);
    //     gameOverCanvas.enabled = true;
    //     Time.timeScale = 0;
    //     Cursor.lockState = CursorLockMode.None;
    //     Cursor.visible = true;
    //     Debug.Log("I DIED");
    // }
}
