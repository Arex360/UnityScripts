using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableLights : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light1;
    public Light light2;
    public bool isEnabled = true;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position,this.transform.position);
       // print(distance);
        if(distance > 60 && distance < 76){
            if(Input.GetKeyDown(KeyCode.K)){
                if(isEnabled){
                  light1.enabled = false;
                  light2.enabled = false;
                  isEnabled = false;
                  print("Closed Lights");  
                }
                else if(!isEnabled){
                    light1.enabled = true;
                    light2.enabled = true;
                    isEnabled = true;
                    print("Lights Opened");
                }
            }
        }
    }
}
