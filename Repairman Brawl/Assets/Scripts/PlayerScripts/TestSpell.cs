using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpell : MonoBehaviour
{
    public GameObject projectile;
    public float minDamage;
    
    public float maxDamage;
    public float projectileForce;
    //public Camera mainCamera;

    public Vector3 offset;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector3 mousePos = Input.mousePosition + offset;
           
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            mousePos = (mousePos - transform.position).normalized;
            Vector3 direction = mousePos.normalized;
            Debug.Log(direction.magnitude);
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<TestProjectile>().damage = Random.Range(minDamage, maxDamage);
        }//mouse doesnt follow
    }
}
