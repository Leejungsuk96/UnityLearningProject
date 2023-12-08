using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEnvent;
    public event Action<Vector2> OnLookEnvent;
    public event Action<AttackSO> OnAttackEvent;

    private float _timeSinceLastAttack = float.MaxValue;
    protected bool IsAttacking { get; set; }
    protected CharacterStatsHandler Stats { get; private set; }

    protected virtual void Awake()
    {
        Stats = GetComponent<CharacterStatsHandler>(); 
    }
    protected virtual void Update()
    {
        HandleAttackDely();
    }

    private void HandleAttackDely()
    {
        if (Stats.CurrentStates.attackSO == null)
            return;

        if(_timeSinceLastAttack <= Stats.CurrentStates.attackSO.delay)
        {
            _timeSinceLastAttack += Time.deltaTime;
        }

        else if(IsAttacking && _timeSinceLastAttack > Stats.CurrentStates.attackSO.delay)
        {
            _timeSinceLastAttack = 0;
            CallAttackEvent(Stats.CurrentStates.attackSO);
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEnvent?.Invoke(direction);
    }
    
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEnvent?.Invoke(direction);
    }

    public void CallAttackEvent(AttackSO attackSO)
    {
        OnAttackEvent?.Invoke(attackSO);
    }
}
