using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    private Rigidbody2D rb;

    private Color color;
    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer=GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.CompareTag("Traps")){
            Debug.Log("colided with trap");
            Die();
        }
    }
    private void Die(){
        Debug.Log("player died");
        spriteRenderer.color=Color.red;
        rb.bodyType = RigidbodyType2D.Static;

        
        Restart();

    }

    private void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
