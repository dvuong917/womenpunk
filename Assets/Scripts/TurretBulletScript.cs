using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBulletScript : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;

    static public bool reflectPhase;

    public float bulletForce = 8;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletForce;
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemCollector.reflectPhase){

            // gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
    
        }
    }
}
