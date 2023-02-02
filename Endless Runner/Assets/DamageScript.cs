using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage;
    float cooldown = 0f;

   
    //private void OnCollisionEnter(Collision collision)
   // {
        //HealthScript health = collision.gameObject.GetComponent<HealthScript>();
        //if (health != null)
        //{
         //   health.TakeDamage(damage);
        //}
   // }
    
    private void OnTriggerEnter(Collider other)
    {
        HealthScript health = other.gameObject.GetComponent<HealthScript>();
        if(health != null)
        {
            health.TakeDamage(damage);
        }
    }
}
