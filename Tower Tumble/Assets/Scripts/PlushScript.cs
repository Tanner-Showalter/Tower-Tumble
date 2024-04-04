using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlushScript : MonoBehaviour
{
    // Level object (note: "Level Manager" exact name is required)
    private GameObject levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("Level Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        levelManager.GetComponent<LevelManager>().DecreasePlushCount();
    }
}
