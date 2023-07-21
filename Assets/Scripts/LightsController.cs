using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour
{
    public bool isflickering = false;
    public float timedelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isflickering == false)
        {
            StartCoroutine(LightON());
        }
    }
    IEnumerator LightON()
    {
        isflickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timedelay = Random.Range(1f, 2f);
        yield return new WaitForSeconds(timedelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timedelay = Random.Range(1.5f, 2.9f);
        yield return new WaitForSeconds(timedelay);
        isflickering = false;
    }
}
