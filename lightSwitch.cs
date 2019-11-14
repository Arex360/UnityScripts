using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
   public Light light;
   public Transform player;
   public Transform box;
   public GameObject toggle; 
   bool status;
   void Start(){
       status = true;
       light = GetComponent<Light>();
       toggle.SetActive(false);

   }
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(box.transform.position,player.position) < 23){
            toggle.SetActive(true);
        }
         else if(Vector3.Distance(box.transform.position,player.position) > 23){
            toggle.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.K) && Vector3.Distance(player.position, box.position) < 21){
            if(status == true){
            light.enabled = false;
            status = false;
            }
            else{
                light.enabled = true;
                status = true;
            }
        }
    }
    
}
