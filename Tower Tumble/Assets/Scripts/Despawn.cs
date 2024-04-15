using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    private float lowerYBound = -0;
    private Coroutine timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = StartCoroutine(loseCoroutine());
    }
    
    IEnumerator loseCoroutine()
    {

        //yield on a new YieldInstruction that waits for 10 seconds.
        yield return new WaitForSeconds(10);
        // In plain english, wait 10 seconds before continuing
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerYBound) {
            Destroy(gameObject);
        }
    }
}
