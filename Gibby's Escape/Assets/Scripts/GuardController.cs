using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public bool GuardMoved;
    public Rigidbody rb;
    public float speed = 2f;

    public GameObject endPoint;

    private Vector3 startingPos;
    private Vector3 endPos;

    private void Awake()
    {
        startingPos = transform.position;
        endPos = endPoint.transform.position;

        GuardMoved = false;
        rb = GetComponent<Rigidbody>();
        transform.LookAt(endPos);

    }
    void FixedUpdate()
    {
        GuardMove();
    }


    private void GuardMove()
    {
        if(GuardMoved == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startingPos, speed * Time.deltaTime);
        }
        
        if (transform.position == endPos)
        {
            transform.Rotate(new Vector3(0f, 180f, 0f));
            GuardMoved = true;
        }
        if (transform.position == startingPos)
        {
            transform.Rotate(new Vector3(0f, 180f, 0f));
            GuardMoved = false;
        }

    }
}
