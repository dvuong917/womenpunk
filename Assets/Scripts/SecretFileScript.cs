using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretFileScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 6) {
            Destroy(gameObject);
        }
    }
    // void OnTriggerEnter2D(Collider2D other) {
    //     if (other.gameObject.CompareTag("Player")) {
    //         Destroy(gameObject);
    //     }
    // }
}
