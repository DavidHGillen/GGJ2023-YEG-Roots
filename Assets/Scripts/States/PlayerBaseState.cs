using UnityEngine;

public abstract class PlayerBaseState : State
{
    //protected readonly StateMachine stateMachine;

    //protected PlayerBaseState(StateMachine stateMachine)
    //{
    //    this.stateMachine = stateMachine;
    //}

    //protected void CalculateMoveDirection()
    //{
    //    Vector3 moveDirection = stateMachine.InputReader.MoveComposite;

    //    stateMachine.Velocity.x = moveDirection.x * stateMachine.MovementSpeed;
    //    stateMachine.Velocity.z = moveDirection.z * stateMachine.MovementSpeed;
    //}

    //protected void Move()
    //{
    //    stateMachine.Controller.Move(stateMachine.Velocity * Time.deltaTime);
    //}
}