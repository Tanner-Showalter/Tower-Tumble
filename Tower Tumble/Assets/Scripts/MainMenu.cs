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
    
    public void PlayLevel3() {
        SceneManager.LoadSceneAsync("Level 3");
    }
    
    public void PlayLevel4() {
        SceneManager.LoadSceneAsync("Level 4");
    }
}
