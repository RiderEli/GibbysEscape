using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GibbyInventory gibbyInventory = other.GetComponent<GibbyInventory>();

        if (gibbyInventory != null)
        {
            //gibbyInventory.playeritemshere
            gameObject.SetActive(false);
        }
    }
}
