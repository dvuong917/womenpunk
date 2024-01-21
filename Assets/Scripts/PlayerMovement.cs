using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]private float speed;
    [SerializeField]private float jumpForce=8f;
    private SpriteRenderer spriteRenderer;


    private Animator anim;
    private LayerMask ground;
    bool isOnGround=false;
    private float xDir;
    public Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();    
        spriteRenderer=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xDir=Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed*xDir,rb.velocity.y);
        

        if(xDir<0){
            spriteRenderer.flipX=true;

        }
        if(xDir>0){
            spriteRenderer.flipX=false;
        }

        if(Input.GetButtonDown("Jump")&&isOnGround){
            Vector2 jumpVector=new Vector2(rb.velocity.x,jumpForce);
            rb.AddForce(jumpVector);
        }

    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            isOnGround=true;
        }
    }
    private void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            isOnGround=false;
        }
    }


}
