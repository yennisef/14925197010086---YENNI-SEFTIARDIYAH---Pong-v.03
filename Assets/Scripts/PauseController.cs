using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public void Pausegame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
