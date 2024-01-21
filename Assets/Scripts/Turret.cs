using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    public float bulletsPerSecond = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float secondsPerBullet = 1 / bulletsPerSecond;
        if (timer > secondsPerBullet)
        {
            timer = 0;
            shoot();
        }

    }

    void shoot()
    {   if(!BossDeath.isDead){
            var temp = Instantiate(bullet, bulletPos.position, Quaternion.identity);
            Destroy(temp, 4.0f);
        }
    } 

}
