using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchlight : MonoBehaviour
{
    Light light;
    bool isActive;
    void Start()
    {
        isActive = true;
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("j")){
            isActive = !isActive;
            if(!isActive){
                light.enabled = false;
            }
            else if(isActive){
                light.enabled = true;
            }
        }
    }
}
