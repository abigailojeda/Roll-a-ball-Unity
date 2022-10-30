using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    //Exit 
    public void Exit()
    {
        Debug.Log("HOlaaaa");
        SceneManager.LoadScene("Menu");
    }
}
