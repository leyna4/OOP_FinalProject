using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player { get; private set; }
    public float MoveSpeed { get; private set; } = 2f;
    public float AttackRange { get; private set; } = 1.2f;

    private BaseState currentState;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        currentState = new ChaseState(this);
    }

    private void Update()
    {
        currentState.Execute();
    }

    public void SwitchState(BaseState newState)
    {
        currentState = newState;
    }

    public void Attack()
    {
        Debug.Log("Enemy attacked player");
    }
}
