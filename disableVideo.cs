using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableVideo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject film;
    public GameObject let;
    public GameObject breakTheWorld;
    public GameObject divide;
    public GameObject angel;
    public GameObject hero;

     bool action;
    void Start() {
         action = true;     
     }
    // Update is called once per frame
     void OnTriggerEnter(Collider other) {
          if(other.gameObject.name == "distancePoint"){
              if(action){
                  let.SetActive(false);
                  breakTheWorld.SetActive(false);
                  divide.SetActive(false);
                  angel.SetActive(false);
                  hero.SetActive(false);
                  action = false;
              }
              else if(!action){
                  play();
                  action = true;
              }
          }    
     }
     void play(){
         int random = Random.Range(1,6);
         if(random == 1){
             let.SetActive(true);
         }
         else if(random == 2){
             breakTheWorld.SetActive(true);
         }
         else if(random == 3){
             divide.SetActive(true);
         }
         else if(random == 4){
             angel.SetActive(true);
         }
         else if(random == 5){
             hero.SetActive(true);
         }
     }
}
