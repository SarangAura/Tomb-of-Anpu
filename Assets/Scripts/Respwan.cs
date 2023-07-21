using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respwan : MonoBehaviour
{
    [SerializeField] public GameObject player;
   
    

    void Update()
    {
       
    }
   

    
    void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.CompareTag("Player"))
        {
            Scene CurrentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(CurrentScene.name);
            
        }
    }
}
