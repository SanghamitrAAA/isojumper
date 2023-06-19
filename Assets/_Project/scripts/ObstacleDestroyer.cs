using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    public float lifeTime = 10f;
    public Rigidbody rb;

    void Start(){
        rb = transform.GetComponent<Rigidbody>();
        //Vector3 MoveVector = new Vector3(0, 3, 3);
        //rb.velocity = new Vector3(0, 3, 0) * Speed;
        rb.AddForce(Vector3.back *40,ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0){
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0)
            {
                Destruction();

            }
        }
        if(this.transform.position.y <= -20)
        {
            Destruction();
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "ObstacleDestroyer")
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
}

