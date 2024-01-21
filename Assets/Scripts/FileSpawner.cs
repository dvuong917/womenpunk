using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject secretFile;
    public float timer;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
            if (timer > 1) {
                var position=new Vector2(Random.Range(-9f, 9f),Random.Range(-3f, 3f));
                Instantiate(secretFile,position,Quaternion.identity);
                timer = 0;
            }
    }
}
