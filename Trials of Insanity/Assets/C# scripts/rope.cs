using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : PlayerInventory
{
    public GameObject objectRope;
    PlayerInventory playerInventory;
    
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            objectRope.SetActive(false);
            if(playerInventory != null)
            {
                playerInventory.RopeCollected();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerInventory = other.GetComponent<PlayerInventory>();
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

    //     if(playerInventory != null)
    //     {
    //         playerInventory.RopeCollected();
    //         objectRope.SetActive(false);
    //     }
    // }
}
