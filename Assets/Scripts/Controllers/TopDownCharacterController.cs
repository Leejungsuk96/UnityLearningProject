using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEnvent;
    public event Action<Vector2> OnLookEnvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEnvent?.Invoke(direction);
    }
    
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEnvent?.Invoke(direction);
    }
}
