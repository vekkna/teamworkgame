using UnityEngine;
using System.Collections;

public class EnemyStateBrain : MonoBehaviour {

    public Transform tr;

    public IEnemyState currentState;

    IEnemyState attackState;
    IEnemyState fleeState;
    IEnemyState patrolState;
    IEnemyState dieState;
    IEnemyState wanderState;

    void Awake() {

        attackState = new EnemyAttack(this);
        fleeState = new EnemyFleeState(this);
        patrolState = new EnemyPatrolState(this);
        wanderState = new EnemyWanderState(this);

        tr = GetComponent<Transform>();
    }

    void Start() {

    }

    void Update() {
        currentState.AIUpdate();
    }

    void FixedUpdate() {
        currentState.AIFixedUpdate();
    }

    void OnTriggerEnter2D(Collider2D other) {
        currentState.AIOnTriggerEnter(other);
    }

}
