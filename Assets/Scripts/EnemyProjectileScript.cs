using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;
    private float timer;
    // Start is called before the first frame update
    public bool shootRight;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 direction = transform.position;
        if (shootRight) {
            rb.velocity = new Vector2(Mathf.Abs(direction.x), 0).normalized * force;
        }
        else {
            rb.velocity = new Vector2(-Mathf.Abs(direction.x), 0).normalized * force;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            // kill player
            Destroy(gameObject);
        }
    }
}
