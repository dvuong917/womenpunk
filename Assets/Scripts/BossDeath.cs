using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeath : MonoBehaviour
{
    // Start is called before the first frame update
        private Color color;
        private Animator anim;
        static public bool isDead=false;

        private BoxCollider2D collider;
        public Rigidbody2D rb;


        private SpriteRenderer spriteRenderer;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();    
        spriteRenderer=GetComponent<SpriteRenderer>();
        collider=GetComponent<BoxCollider2D>();
 
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();

    }

    void OnCollisionEnter2D(Collision2D col) {

            anim.SetTrigger("Boss Death");
            Debug.Log("Boss Died!!!");
            spriteRenderer.color=Color.red;
            isDead=true;

    }

    void TurnOffStaticBody(){
        rb.bodyType = RigidbodyType2D.Dynamic;
        collider.enabled=false;
    }
}
