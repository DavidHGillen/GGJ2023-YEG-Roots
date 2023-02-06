using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageUp : MonoBehaviour
{
    public string UpMessage;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))gameObject.SendMessageUpwards(UpMessage);
    }
}
