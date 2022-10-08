using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    System.Random rand = new System.Random();
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Object") //checks for object in deathbox
        {

            Vector3 position = collision.transform.position; //takes object pos.

            int RandPos = rand.Next(-2,2); //moves randomly left or right to new pos.
            position.x = RandPos;

            position.y = 8; //set height

            position.z = 0; //set offset
            
            collision.transform.position = position; //applies new pos.
            collision.transform.rotation = Quaternion.Euler(0, 0, 0); //resets angles of object to avoid rolling loop
            collision.attachedRigidbody.velocity = Vector3.zero; //resets velocity to allow object to fall directly down

            int FallSpeed = rand.Next(-15,5); //random speed for variety
            collision.attachedRigidbody.AddForce(0,FallSpeed,0, ForceMode.VelocityChange); //applies to object

        }    
    }
}
