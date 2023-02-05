using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : State
{
    Vector2 mov;
    public override void Enter()
    {
      
    }

    public override void Exit()
    {
        
    }

    public override void Tick()
    {
        if (CharacterController.character.Velocity.magnitude > 0)
        {
            CharacterController.character.SwitchState(new PlayerMoveState());
        }
    }
}
