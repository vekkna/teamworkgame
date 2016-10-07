using UnityEngine;

public interface IEnemyState {

    void AIInit();
    void AIUpdate();
    void AIFixedUpdate();
    void AIOnTriggerEnter(Collider2D other);
    void AIOnEnterState();
    void AIOnLeaveState();
}
