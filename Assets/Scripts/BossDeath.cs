using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeath : MonoBehaviour
{
    // Start is called before the first frame update
        private Color color;
        private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
 
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();

    }

    void OnCollisionEnter2D(Collision2D col) {
        
            Debug.Log("Boss Died!!!");
            spriteRenderer.color=Color.red;

    }
}
