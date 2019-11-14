using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookArround : MonoBehaviour
{
   private Transform player;
    Vector2 mouseLook;
    void Start()
    {
        player = this.transform.parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MouseC = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseLook += MouseC;
        this.transform.localRotation =  Quaternion.AngleAxis(-mouseLook.y,Vector3.right);
       player.localRotation = Quaternion.AngleAxis(mouseLook.x,Vector3.up);
       
    }
}
