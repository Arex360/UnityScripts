using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speakerDistance : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject speaker;
    public Transform player;
    bool isAudioActive;
    void Start()
    {
        isAudioActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position,this.transform.position);
        if(distance < 162 && distance > 19){
              speaker.SetActive(isAudioActive);               
        }
        else if(distance > 162){
            speaker.SetActive(!isAudioActive);
        }
    }
}
