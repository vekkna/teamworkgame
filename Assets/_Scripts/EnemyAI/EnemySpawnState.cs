﻿using UnityEngine;
using System;

public class EnemySpawnState : IEnemyState {

    EnemyStateBrain brain;

    public EnemySpawnState(EnemyStateBrain b) {
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
