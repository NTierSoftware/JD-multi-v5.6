using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour{

    void OnCollisionEnter(Collision collision){
        //var hit = collision.gameObject;
        //var health = collision.gameObject.GetComponent<Health>();
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null) health.TakeDamage(10);

        Destroy(gameObject);
    }//OnCollisionEnter

    
    //void Start(){}
    // Update is called once per frame
    //void Update(){}

}//class Bullet