using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openFridge : MonoBehaviour
{
        public Transform player;
        public GameObject toggle;
        public Light light1;
        public Light light2;
        public Light light3;
        public Light light4;
        public Light light5;
        public Light light6;
        public Light light7;
        public Light light8;
        public Light light9;
        public Light light10;
        public Light light11;
        public Light light12;
        public Light light13;

        bool isOpened;
        private void Start() {
            isOpened = true;
        }
        void Update()
    {
        float distance = Vector3.Distance(player.position,this.transform.position);
       // print(distance);
        if(Input.GetKeyDown(KeyCode.K) &&  Vector3.Distance(player.position,this.transform.position) < 50){
                if(isOpened){
                    light1.enabled = false;
                    light2.enabled = false;
                    light3.enabled = false;
                    light4.enabled = false;
                    light5.enabled = false;
                    light6.enabled = false;
                    light7.enabled = false;
                    light8.enabled = false;
                    light9.enabled = false;
                    light10.enabled = false;
                    light11.enabled = false;
                    light12.enabled = false;
                    light13.enabled = false;
                    isOpened = false;
                    print("All lights have been closed");
                }
                else if(!isOpened){
                    light1.enabled = true;
                    light2.enabled = true;
                    light3.enabled = true;
                    light4.enabled = true;
                    light5.enabled = true;
                    light6.enabled = true;
                    light7.enabled = true;
                    light8.enabled = true;
                    light9.enabled = true;
                    light10.enabled = true;
                    light11.enabled = true;
                    light12.enabled = true;
                    light13.enabled = true;
                    isOpened = true;
                    print("All lights have been open");
                }
           }

        }
    }

