using System;
using UnityEngine;

public class EnemyAttack : IEnemyState {

    EnemyStateBrain brain;


    public void AIFixedUpdate() {

    }

    public void AIInit() {

    }

    public void AIOnTriggerEnter(Collider2D other) {

    }

    public void AIUpdate() {

    }

    public void AIOnEnterState() {

    }

    public void AIOnLeaveState() {

    }

    public EnemyAttack(EnemyStateBrain b) {
        brain = b;
    }
}