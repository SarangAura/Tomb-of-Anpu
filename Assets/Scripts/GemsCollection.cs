using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsCollection : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "player")
        {
             other.GetComponent<Movement>().points++;
            Destroy(gameObject);
        }
    }
}
