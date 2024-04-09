using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LauncherScript : MonoBehaviour
{
    // Input Variables
    public float mass;
    public float angle;
    public float force;
    
    // Other variables/object references
    public GameObject forceInput;
    public GameObject massInput;
    public GameObject angleInput;
    public TextMeshProUGUI shotText;
    private GameObject levelManager;
    public GameObject projectilePrefab;

    // Local shot count for limiting shots
    private int shotCount;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("Level Manager");
        shotCount = levelManager.GetComponent<LevelManager>().shotCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shotCount > 0) {
            // Obtain values
            force = float.Parse(forceInput.GetComponent<TMP_InputField>().text);
            mass = float.Parse(massInput.GetComponent<TMP_InputField>().text);
            angle = float.Parse(angleInput.GetComponent<TMP_InputField>().text);
            Fire();
        }
    }

    // Launch cannonball
    void Fire()
    {
        Debug.Log("Firing");
        // Instantiate cannonball
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        projectileRb.mass = mass;
        // Apply forces
        // Last parameter may be changed if the shooter is rotated. Below handles basic firing in 2d
        Vector3 projectileDir = new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle), Mathf.Sin(Mathf.Deg2Rad * angle), 0);
        projectileRb.AddForce(projectileDir * force, ForceMode.Impulse);
        // Reduce shot counters
        shotCount--;
        levelManager.GetComponent<LevelManager>().DecreaseShotCount();
    }
}
