using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    // UI Elements for level
    public TextMeshProUGUI shotText;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI plushText;

    // Count of plushies, will go down as collected
    private int plushCount;
    
    public int shotCount;

    private bool lost = false;

    // Used to track lost coroutine, mostly to stop it
    private Coroutine lostC;

    // Start is called before the first frame update
    void Start()
    {
        plushCount = GameObject.FindGameObjectsWithTag("Plushie").Length;
        plushText.text = "Plushies Remaining: " + plushCount;
        winText.enabled = false;
        shotText.text = "Shots: " + shotCount;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecreasePlushCount() 
    {
        plushCount--;
        plushText.text = "Plushies Remaining: " + plushCount;
        if (plushCount <= 0) 
        {
            winFunc();
        }
    }

    public void DecreaseShotCount()
    {
        shotCount--;
        shotText.text = "Shots: " + shotCount;
        if(shotCount <= 0 && !lost)
        {
            lostC = StartCoroutine(loseCoroutine());
        }
    }

    // When the player fires their last shot, timer starts here.
    // After 5 seconds, if plushies are still uncollected, then trigger loss
    IEnumerator loseCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        // In plain english, wait 5 seconds before continuing

        if (plushCount > 0) {
            loseFunc();
        }
    }

    // Does all the stuff for winning
    private void winFunc() 
    {
        winText.text = "You Win!";
        winText.enabled = true;
        if (lostC != null) {
            StopCoroutine(lostC);
        }

        // Pauses the game after win, time scale will need reset to 1 for play to continue
        Time.timeScale = 0;
    }

    // Does all the stuff for losing
    private void loseFunc()
    {
        winText.text = "You Lost!";
        winText.enabled = true;
        lost = true;
        Time.timeScale = 0;
    }
}
