using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public Transform player;
    public GameObject door;
    bool isOpen;
    void Start(){
         isOpen = false;
    }
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.E) &&  Vector3.Distance(player.position,this.transform.position) < 33){
           if(!isOpen){
               this.transform.localRotation =  Quaternion.AngleAxis(-90f,Vector3.up);
               isOpen = true;
               door.SetActive(true);
               print("door is opened");

           }
           else if(isOpen){
               this.transform.localRotation =  Quaternion.AngleAxis(0,Vector3.up);
               isOpen = false;
               door.SetActive(true);
               print("door is closed");
           }
        }
    }
}
