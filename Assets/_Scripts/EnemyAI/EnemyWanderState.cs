using UnityEngine;

public class EnemyWanderState : IEnemyState {

    EnemyStateBrain brain;
    Vector2 waypoint;
    float threshold;

    public EnemyWanderState(EnemyStateBrain b) {
        brain = b;
    }

    public void AIUpdate() {
        if (Vector2.SqrMagnitude(waypoint - (Vector2)brain.tr.position) < threshold) {
            waypoint = GetNewWaypoint();
        }
    }

    public void AIFixedUpdate() {

    }

    public void AIInit() {

    }

    public void AIOnEnterState() {

        Debug.Log("Entering wander state");
    }

    public void AIOnLeaveState() {

        Debug.Log("Leaving wander state");
    }

    public void AIOnTriggerEnter(Collider2D other) {

    }

    Vector2 GetNewWaypoint() {
        Vector2 randomPos = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
        float distanceAhead = 5f;


        return Vector2.zero;
    }

}
