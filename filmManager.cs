using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filmManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject angel;
    public GameObject letmedown;
    public GameObject breakTheWorld;
    public GameObject divided;
    public GameObject heroDiv;
    public Transform player;
    void Start()
    {
        angel.SetActive(false);
        letmedown.SetActive(false);
        breakTheWorld.SetActive(false);
        divided.SetActive(false);
        heroDiv.SetActive(false);
        startVideo();
        
    }
    void Update(){
        float distance = Vector3.Distance(player.position,this.transform.position);
       // print(distance);
        
    }
    void startVideo(){
            int number = Random.Range(1,6);
            print(number);
            if(Vector3.Distance(player.position,this.transform.position) < 150){
                if(number==1){
                angel.SetActive(true);
                print("Starting 1");
            }
            else if(number == 2){
                letmedown.SetActive(true);
                print("starting 2");
            }
            else if(number == 3){
                breakTheWorld.SetActive(true);    
            }
            else if(number == 4){
                divided.SetActive(true);
            }
            else if(number == 5){
                heroDiv.SetActive(true);
            }
            }
            else if(Vector3.Distance(player.position,this.transform.position) > 150) {
                angel.SetActive(false);
                letmedown.SetActive(false);
            }
        }

    // Update is called once per frame
    
}
