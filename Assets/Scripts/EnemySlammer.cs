using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
    

public class Slammer : MonoBehaviour
{

    public float baseSpeed = 3;
    public List<Transform> waypoints;

    private int target = 0;
    private float moveSpeed = 1;

    // receieve data
    void Update()
    {
        //receieve data
        transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position, Mathf.Max(baseSpeed,moveSpeed) * Time.deltaTime);

        // once you get to one waypoint, aim for the next one
        if (transform.position == waypoints[target].position)
        {
            // once you reach the end
            if (target == waypoints.Count - 1)
            {
                target = 0; // aim for the starting point
                moveSpeed = baseSpeed; // slow down after object is launched
            }
            else
            {
                if (target == 1) moveSpeed *= 20; // accelerate object
                target += 1;
            }
        }
    }

    /*
    // use data
    private void fixedUpdate()
    {
        if (transform.position == waypoints[target].position)
        {
            if (target == waypoints.Count - 1)
            {
                target = 0;
            }
            else
            {
                target += 1;
            }
        }
    }
    */
}
