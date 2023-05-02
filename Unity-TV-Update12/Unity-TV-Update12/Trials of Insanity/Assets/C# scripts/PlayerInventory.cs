using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : Collectable
{
    private int ropeItem; //{get; private set;}

    public void RopeCollected()
    {
        ropeItem++;
    }
}
