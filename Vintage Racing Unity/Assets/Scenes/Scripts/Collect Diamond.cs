using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDiamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.TryGetComponent<PlayerInventory>(out var playerInventory))
        { playerInventory.DiamondCollected();
        gameObject.SetActive(false);}
    }
}

internal class PlayerInventory
{
    internal void DiamondCollected()
    {
        throw new NotImplementedException();
    }
}