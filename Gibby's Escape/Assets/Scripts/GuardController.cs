using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public bool GuardMoved;

    // Update is called once per frame
    void Update()
    {
        GuardMove();
    }

    private void GuardMove()
    {
        if (GuardMoved = false)
        {
            StartCoroutine(GuardWalk());
        }
    }

    public IEnumerator GuardWalk()
    {
        GuardMoved = true;
        transform.Translate(Vector3.forward);
        yield return new WaitForSeconds(2f);
        transform.Translate(Vector3.back);
        yield return new WaitForSeconds(2f);
        GuardMoved = false;
    }
}
