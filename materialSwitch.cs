using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialSwitch : MonoBehaviour
{
    public Transform player;
    Renderer render;
    public Material Rmaterial;
    public Material Wmaterial;
    bool isSelected;
    void Start()
    {
        render = GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = Wmaterial;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K) && Vector3.Distance(player.position,this.transform.position) < 24){
            if(!isSelected){
                render.sharedMaterial = Rmaterial;
                isSelected = true;
            }
            else if(isSelected){
                render.sharedMaterial = Wmaterial;
                isSelected = false;
            }
        }
    }
}
