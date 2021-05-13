using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinScript : MonoBehaviour
{
    [SerializeField] Canvas gameWinCanvas;

    void OnCollisionEnter(Collision collison)
    {
        gameWinCanvas.enabled = true;
        Time.timeScale = 0;
    }
}
