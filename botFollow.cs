using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botFollow : MonoBehaviour
{
    public GameObject bot;
    bool active;
    public Vector3 distance;
    void Start()
    {
        bot.SetActive(false);
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        bot.transform.position = transform.position + distance;
        
        if(Input.GetKeyDown(KeyCode.R)){
            if(active == false){
                bot.SetActive(true);
                active = true;
            }
            else if(active != false){
                bot.SetActive(false);
                active = false;
            }
        }
    }
}
