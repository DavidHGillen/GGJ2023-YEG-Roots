using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : StateMachine
{
    public static CharacterController character;

    public float MovementSpeed { get; private set; } = 5f;
    public float alteratedMovementSpeed;
    public float RollForce = 5f;
    public float rollCooldown = 1f;
    public float attackCooldown = 0.5f;
    public GameObject attackRange;
    public InputReader InputReader { get; private set; }
    public Animator Animator;
    public Rigidbody rb { get; private set; }

    public float currentSpeed;

    public Vector3 Velocity { get; private set; }
    public Vector2 moveComposite { get; private set; }
    private Vector3 lastMovement;


    bool rolling;
    bool attacking;

    enum faceDirection
    {
        North,
        East,
        South,
        West
    }

    enum States
    {
        Idle,
        Walk,
        Roll,
        Attacking
    }
    
    private void Awake()
    {
        if (character != null) character = this;    
    }

    private void Start()
    {
        alteratedMovementSpeed = MovementSpeed / 2;
        currentSpeed = MovementSpeed;

        attackRange.SetActive(false);

        InputReader = GetComponent<InputReader>();
        rb = GetComponent<Rigidbody>();

        SwitchState(new PlayerIdleState());
    }

    private void Update()
    {        
        Velocity = new Vector3(moveComposite.x,0,moveComposite.y);
        if(Velocity.magnitude>0) lastMovement = Velocity;
        Animator.SetFloat("VelX", Velocity.x);
        Animator.SetFloat("VelY", Velocity.z);
    }

    private void FixedUpdate()
    {
        if(!rolling && !attacking ) rb.velocity = Velocity * currentSpeed;
    }

    public void OnMove(InputValue value)
    {
        moveComposite = value.Get<Vector2>();        
    }

    void OnRoll()
    {
        rolling = true;
        StartCoroutine(RollCooldown());
        if(!rolling)rb.AddRelativeForce(RollForce*lastMovement.normalized);
    }

    void OnAttack()
    {
        attacking = true;
        StartCoroutine(AttackCooldown());
        attackRange.transform.position = transform.position + lastMovement;
        attackRange.SetActive(true);
    }

    void EndAttack() { }

    IEnumerator RollCooldown()
    {
        yield return new WaitForSeconds(rollCooldown);
        rolling = false;
    }
    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        attackRange.SetActive(false);
        attacking = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Root")) {
            currentSpeed = alteratedMovementSpeed;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Root")) {
            currentSpeed = MovementSpeed;
        }
    }
}
