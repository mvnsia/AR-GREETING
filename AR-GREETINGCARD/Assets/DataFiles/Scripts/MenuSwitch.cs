using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void greetingcard()
    {
        SceneManager.LoadScene("AR-GREETING");
    }

    public void rotatecube()
    {
        SceneManager.LoadScene("RotateCube");
    }

    public void exitbtn()
    {
        Application.Quit();
        Debug.Log("exit button pressed");
    }

    public void backbtn()
    {
        SceneManager.LoadScene("Menu");
    }
}
