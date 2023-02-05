using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roots : MonoBehaviour
{
    public GameObject collider;
    public void EnableCollider()
    {
        collider.SetActive(true);
        collider.tag = "Root";
    }

}
