using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    System.Random rand = new System.Random();
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Object")
        {

            Vector3 position = collision.transform.position;

            int RandPos = rand.Next(-2,2);
            position.x = RandPos;

            position.y = 8;

            position.z = 0;
            
            collision.transform.position = position;
            collision.transform.rotation = Quaternion.Euler(0, 0, 0);
            collision.attachedRigidbody.velocity = Vector3.zero;

            int FallSpeed = rand.Next(-15,5);
            collision.attachedRigidbody.AddForce(0,FallSpeed,0, ForceMode.VelocityChange);

        }    
    }
}
