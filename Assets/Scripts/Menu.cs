using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   //First Level
   public void FirstLEvel()
    {
        SceneManager.LoadScene("MiniGame");
    }

    //Second Level
    public void SecondLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }


}
