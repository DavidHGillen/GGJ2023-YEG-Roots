using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    public Vector2 moveComposite;

    public void OnFire()
    {

    }

    public void OnMove(InputValue value)
    {
        moveComposite = value.Get<Vector2>();
    }
}
