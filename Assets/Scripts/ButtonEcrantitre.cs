using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEcrantitre : MonoBehaviour
{
    public void ToTheGame()
    {
        SceneManager.LoadScene("Lvl0");
       
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
}
