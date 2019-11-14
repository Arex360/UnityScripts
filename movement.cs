using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   public float speed;
   public GameObject footsteps;
   public GameObject doorSound;
   public Animator animator;
   public Rigidbody rigidbody;
   //public Collider collider;
    void Start(){
      animator = this.GetComponent<Animator>();
      footsteps.SetActive(false);
      doorSound.SetActive(false);
    //  collider = this.GetComponent<Collider>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
       float movementZ = Input.GetAxis("Vertical") * Time.deltaTime;
       float movementX = Input.GetAxis("Horizontal") * Time.deltaTime;
       if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
           animator.SetBool("isRunning",true);
           this.transform.Translate(Vector3.right * movementX *speed);
           footsteps.SetActive(true);
       }
       else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
           animator.SetBool("isRunning",true);
           this.transform.Translate(Vector3.forward * movementZ *speed);
           footsteps.SetActive(true);
       }
       else if(Input.GetKey(KeyCode.Space)){
           animator.SetBool("isJumping",true);
           this.transform.Translate(Vector3.up * movementZ *speed);
           rigidbody.AddForce(0,0,30*Time.deltaTime);
       }
       else if(Input.GetKey(KeyCode.B)){
           animator.SetBool("isSlidding",true);
           this.transform.Translate(Vector3.forward * movementZ * speed);
       }
       else if(Input.GetKey(KeyCode.F)){
           animator.SetBool("isFlipping",true);
          
       }
       else if(Input.GetKey(KeyCode.G)){
           animator.SetBool("isEddyStyle",true);
           pos.z += 20 * Time.deltaTime;
       }
       else if(Input.GetKey(KeyCode.K)){
           animator.SetBool("isKicking",true);
       }
        else{
            transform.position = pos;
            animator.SetBool("isRunning",false);
            animator.SetBool("isFlipping",false);
            animator.SetBool("isEddyStyle",false);
            animator.SetBool("isJumping",false);
            animator.SetBool("isSlidding",false);
            animator.SetBool("isKicking",false);
            footsteps.SetActive(false);
        }
    }
}
