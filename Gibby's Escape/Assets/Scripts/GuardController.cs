using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public bool GuardMoved;
    public Rigidbody rb;
    public float speed = 5f;

    private void Awake()
    {
        GuardMoved = false;
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        GuardMove();
    }

    private void GuardMove()
    {
        if (GuardMoved == false)
        {
            StartCoroutine(GuardWalk());
        }
    }

    public IEnumerator GuardWalk()
    {
        GuardMoved = true;
        rb.velocity = speed * (Vector3.forward);
        yield return new WaitForSeconds(2f);
        transform.Rotate(new Vector3(0f, 180f, 0f));
        yield return new WaitForSeconds(1f);
        rb.velocity = speed * (Vector3.back);
        yield return new WaitForSeconds(2f);
        transform.Rotate(new Vector3(0f, 180f, 0f));
        yield return new WaitForSeconds(1f);
        GuardMoved = false;
    }
}
