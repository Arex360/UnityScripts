using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    public float offsetX;
    public float offsetY;
    public float zoom;
    public float followSpeed;
    public bool alongZ;
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if(!(player.transform.position.y < -2.6f))
        {
            if (alongZ)
            {
                Vector3 pos = new Vector3(player.transform.position.x + offsetX, player.transform.position.y + offsetY, zoom + player.transform.position.z);
                this.transform.position = Vector3.Lerp(this.transform.position, pos, followSpeed * Time.deltaTime);
            }
            else
            {
                Vector3 pos = new Vector3(player.transform.position.x + offsetX, player.transform.position.y + offsetY, zoom);
                this.transform.position = Vector3.Lerp(this.transform.position, pos, followSpeed * Time.deltaTime);
            }
     
        }
    }
}
