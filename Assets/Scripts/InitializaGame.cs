using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class InitializaGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TouchSimulation.Enable();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Minigame");
    }

}
