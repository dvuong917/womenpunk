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
        if(ItemCollector.reflectPhase){
            if(coll.gameObject.CompareTag("BossBullet")){
                Debug.Log("bounce with bossBullet");
                coll.gameObject.GetComponent<CircleCollider2D>().isTrigger=false;
               
            }
        }
        else if(!ItemCollector.reflectPhase && (coll.gameObject.CompareTag("Traps")||coll.gameObject.CompareTag("BossBullet"))){
            Debug.Log("collided with trap");
            Die();
        }
        else if(coll.gameObject.CompareTag("Traps")){
            Debug.Log("collided with trap");
            Die();
        }
        
    }

    private void Die(){
        Debug.Log("player died");
        spriteRenderer.color=Color.red;
        anim.SetTrigger("Kill Player");
        rb.bodyType = RigidbodyType2D.Static;

    }

    private void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
