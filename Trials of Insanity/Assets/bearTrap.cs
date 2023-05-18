using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearTrap : MonoBehaviour
{
    public Animator trapAnimator; // Reference to the Animator component

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Trigger the animation
            trapAnimator.SetTrigger("TrapTriggered");
        }
    }
}
