using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roate : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 rotate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pRotate = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        rotate += pRotate;
        this.transform.localRotation = Quaternion.AngleAxis(pRotate.x,Vector3.up);
    }
}
