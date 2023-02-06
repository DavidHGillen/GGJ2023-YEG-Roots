using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    Transform player;
    Animator animator;
    public GameObject slam;
    GameObject generatedSlam;

    protected bool isAngry;

    void Start()
    {
        isAngry = false;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        animator.SetBool("Active", isAngry);
        if (!isAngry) { return; }

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

    public void beAngryMessage()
    {
        isAngry = true;
    }
}
