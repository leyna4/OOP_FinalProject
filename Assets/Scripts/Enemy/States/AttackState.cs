using UnityEngine;

public class AttackState : BaseState
{
    private float attackCooldown = 1f;
    private float lastAttackTime;

    public AttackState(Enemy enemy) : base(enemy)
    {
        lastAttackTime = Time.time;
    }

    public override void Execute()
    {
        float distance = Vector3.Distance(enemy.transform.position, enemy.Player.position);

        if (distance > enemy.AttackRange)
        {
            enemy.SwitchState(new ChaseState(enemy));
            return;
        }

        if (Time.time >= lastAttackTime + attackCooldown)
        {
            enemy.Attack();
            lastAttackTime = Time.time;
        }
    }
}
