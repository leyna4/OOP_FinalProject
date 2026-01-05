using UnityEngine;

public class ChaseState : BaseState
{
    public ChaseState(Enemy enemy) : base(enemy) { }

    public override void Execute()
    {
        Vector3 direction = (enemy.Player.position - enemy.transform.position).normalized;
        enemy.transform.Translate(direction * enemy.MoveSpeed * Time.deltaTime);

        float distance = Vector3.Distance(enemy.transform.position, enemy.Player.position);

        if (distance <= enemy.AttackRange)
        {
            enemy.SwitchState(new AttackState(enemy));
        }
    }
}
