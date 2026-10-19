using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

    private GameObject pointLight

    // Start is called before the first frame update
    void Start()
    {
        pointLight = GameObject.Find("Lightbulb");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            bool lightOn = pointLight.enabled;
            if(lightOn)
            {
                pointLight.enabled = false;
            }
            else if(!lightOn)
            {
                pointLight.enabled = true;
            }
        }

    }
}
