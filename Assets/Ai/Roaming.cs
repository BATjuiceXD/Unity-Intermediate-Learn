using UnityEngine;
using UnityEngine.AI;

public class Roaming : State
{
    public Roaming(Enemy enemy, NavMeshAgent agent) : base(enemy, agent)
    {
        Name = STATE.ROAMING;
    }
    public override void Enter()
    {
        int locationQuantity = EnemyClass.ObserveLocation.Length;

        Agent.SetDestination(SearchWaypoint(locationQuantity));

        base.Enter();
    }
    public override void Update()
    {
        if(Agent.remainingDistance < .5f)
        {
            /// ถ้าระยะเหลือน้อยกว่า0.5m set Nextstate to idel
            int locationQuantity = EnemyClass.ObserveLocation.Length;

            Agent.SetDestination(SearchWaypoint(locationQuantity));

        }
        base.Update();
    }
    public override void Exit()
    {
        base.Exit();
    }
    private Vector3 SearchWaypoint(int locationQuantity)
    {
        /// Random point of interrest
        int index = Random.Range(0, locationQuantity);

        /// Set estimate destination
        Vector3 destination = EnemyClass.ObserveLocation[index].position;
        NavMeshHit hit;
        if(NavMesh.SamplePosition(destination, out hit, 1.0f, NavMesh.AllAreas))
        {
            destination = hit.position;
        }
        else{
            destination = SearchWaypoint(locationQuantity);
        }
    return destination;
    }
}
