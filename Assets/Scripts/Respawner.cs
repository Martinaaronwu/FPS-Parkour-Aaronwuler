using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Respawner : MonoBehaviour
{
    public float yRespawnValue;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yRespawnValue)
        {
            Debug.Log("Me caí che");
            SceneManager.LoadScene("FPS Parkour");
        }

    }
}
