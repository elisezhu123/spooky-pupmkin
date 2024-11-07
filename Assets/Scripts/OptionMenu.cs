using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class OptionMentu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Options()
    {
         SceneManager.LoadSceneAsync(0); //Load the option scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
