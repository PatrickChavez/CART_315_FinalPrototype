using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideReset : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("Reset!");
            // Code from JeanLuc
            // get the current scene name 
            string sceneName = SceneManager.GetActiveScene().name;

            // load the same scene
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
