using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public Text textComponent;
    public float currentHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Constraining currenthealth
        currentHealth = Mathf.Clamp(currentHealth, 0, 100);

        textComponent.text = "Health: " + currentHealth.ToString();

        if (currentHealth <= 0)
        {
            // Code from JeanLuc
            // get the current scene name 
            string sceneName = SceneManager.GetActiveScene().name;

            // load the same scene
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }

}
