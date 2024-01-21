using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowShield : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sprite;
    void Start()
    {
        sprite=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemCollector.reflectPhase){
            sprite.enabled=true;
        }else{
            sprite.enabled=false;
        }
    }
}
