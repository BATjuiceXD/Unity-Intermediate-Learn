using UnityEngine;
using UnityEngine.AI;
public class Chasing : State
{
    public Chasing(Enemy enemy, NavMeshAgent agent) : base(enemy, agent)
    {
        Name = STATE.CHASING;
    }
    public override void Enter()
    {
        
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
    }
}
