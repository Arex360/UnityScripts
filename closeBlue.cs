using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBlue : MonoBehaviour
 {
    
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Transform player;
    bool isOpened;
    void Start()
    {
        isOpened = true;     
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position,this.transform.position);
       // print(distance);
        if(Input.GetKeyDown(KeyCode.K) &&(distance > 21 && distance < 32)){
            if(isOpened){
                light1.enabled = false;
                light2.enabled = false;
                light3.enabled = false;
                light4.enabled = false;
                light5.enabled = false;
                isOpened = false;
            }
            else if(!isOpened){
                light1.enabled = true;
                light2.enabled = true;
                light3.enabled = true;
                light4.enabled = true;
                light5.enabled = true;
                isOpened = true;
            
            }
        }
    }
}
