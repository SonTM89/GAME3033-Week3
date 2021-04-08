using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Systems.Health;

public class ZombieHealthComponent : HealthComponent
{
    private StateMachine ZombieStateMachine;

    private void Awake()
    {
        ZombieStateMachine = GetComponent<StateMachine>();
    }

    public override void Destroy()
    {
        //base.Destroy();

        ZombieStateMachine.ChangeState(ZombieStateType.Dead);
    }
}