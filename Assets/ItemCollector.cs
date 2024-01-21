using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField]private Text secretFileCountText;
    private float secretFileLeft=5;
    [SerializeField]private FileSpawner fileSpawner;

    public bool reflectPhase=false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        secretFileCountText.text="Files left to collect: "+secretFileLeft;

        fileSpawner=GetComponent<FileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.CompareTag("SecretFile")){
            Debug.Log("colided with secret file");
            Destroy(coll.gameObject);
            secretFileLeft--;
            secretFileCountText.text="Files left to collect: "+secretFileLeft;
            

            if(secretFileLeft==0){
                if(secretFileCountText!=null){
                    // Destroy(secretFileCountText);
                    GameObject.Find("Secret File Spawner").GetComponent<FileSpawner>().enabled=false;
                    reflectPhase=true;
                }                
            }

        }
    }

    // if(collision.gameObject.CompareTag("jump boost")){
    //     Destroy(collision.gameObject);
    //     GameObject.Find("Player").GetComponent<PlayerMovement>().increaseJumpForce(4f);//looks kinda crappy
    // }
}
