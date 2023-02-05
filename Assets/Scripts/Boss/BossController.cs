using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    Transform player;
    Animator animator;
    public GameObject slam;
    GameObject generatedSlam;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        animator.SetFloat("Distance", dist);
    }

    public void Slam()
    {

        generatedSlam = Instantiate(slam, transform);
    }

    public void DestroySlam()
    {
        Destroy(generatedSlam);
    }
}
