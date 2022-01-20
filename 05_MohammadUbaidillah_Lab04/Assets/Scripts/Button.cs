using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void RestartButton()
    {
        SceneManager.LoadScene("GamePlay_Level1");
    }
}
