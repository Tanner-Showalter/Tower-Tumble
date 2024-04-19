using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayLevel1() {
        SceneManager.LoadSceneAsync("Tutorial Level");
    }
    
    public void PlayLevel2() {
        SceneManager.LoadSceneAsync("Level 2");
    }
}
