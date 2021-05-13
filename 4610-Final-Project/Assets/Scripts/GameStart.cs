using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] Canvas gameStartCanvas;
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas heathCanvas;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.enabled = false;
        heathCanvas.enabled = false;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
