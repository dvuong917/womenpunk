using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    private Rigidbody2D rb;

    public Text deathCounter;
    private static int deathCount = 0;

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
        deathCounter.text = "Deaths: " + deathCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D coll){
        if(ItemCollector.reflectPhase){
            if(coll.gameObject.CompareTag("BossBullet")){
                Debug.Log("bounce with bossBullet");
                coll.gameObject.GetComponent<CircleCollider2D>().isTrigger=false;
            }
        }
        else if(!ItemCollector.reflectPhase && coll.gameObject.CompareTag("Traps")||coll.gameObject.CompareTag("BossBullet")){
            Debug.Log("collided with trap");
            Die();
        }
        
    }

    private void Die(){
        Debug.Log("player died");
        spriteRenderer.color=Color.red;
        rb.bodyType = RigidbodyType2D.Static;
        deathCount += 1;
        
        Restart();

    }

    private void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
