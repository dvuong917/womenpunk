using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Slammer : MonoBehaviour
{

    public float baseSpeed = 3f;
    public List<Transform> waypoints;
    public float accelerationAmount = 20f;

    private int target = 0;
    private float moveSpeed = 1f;
    private bool isMovingForward = true;

    void Start()
    {
        moveSpeed = baseSpeed;
    }

    private void move()
    {
        if (isMovingForward)
        {
            target += 1;
        }
        else
        {
            target -= 1;
        }
    }

    // receieve data
    void Update()
    {
        //receieve data
        transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position, moveSpeed * Time.deltaTime);

        // once you get to one waypoint, aim for the next one
        if (transform.position == waypoints[target].position)
        {
            // once you reach the end
            if (target == waypoints.Count - 1)
            {
                isMovingForward = false;
                moveSpeed = baseSpeed; // slow down after object is launched
            }
            else if (target == 1 && isMovingForward)
            {
                moveSpeed *= accelerationAmount; // accelerate object
            }
            else if (target == 0)
            {
                isMovingForward = true; // move forward from starting point
            }
            move();
        }
    }
}