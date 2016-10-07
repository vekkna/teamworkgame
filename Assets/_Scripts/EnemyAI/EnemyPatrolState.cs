using UnityEngine;
using System;

public class EnemyPatrolState : IEnemyState {

    EnemyStateBrain brain;

    public EnemyPatrolState(EnemyStateBrain b) {
        brain = b;
    }

    public void AIFixedUpdate() {
        throw new NotImplementedException();
    }

    public void AIInit() {
        throw new NotImplementedException();
    }

    public void AIOnEnterState() {
        throw new NotImplementedException();
    }

    public void AIOnLeaveState() {
        throw new NotImplementedException();
    }

    public void AIOnTriggerEnter(Collider2D other) {
        throw new NotImplementedException();
    }

    public void AIUpdate() {
        throw new NotImplementedException();
    }


}
