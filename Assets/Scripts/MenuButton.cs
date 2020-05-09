using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * A MonoBehaviour class that sets up a play button 
 */
public class MenuButton : MonoBehaviour
{
    public void LoadScene(int sceneBuildIndex)
    {
        //Loads the next scene on click
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
