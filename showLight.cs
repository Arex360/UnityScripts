using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLight : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public GameObject toggle;
    bool isActive = true;
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position,toggle.transform.position) < 38){
            toggle.SetActive(isActive);
        }
        else if(Vector3.Distance(player.position,toggle.transform.position) > 38){
            toggle.SetActive(!isActive);
        }
    }
}
