using System;
using UnityEngine;
using UnityEngine.AI;
public class State 
{
   ///<summary>
   /// Event for other fucntion
   /// to trigger when State is change
   /// </summary>
   public event Action OnstateChanged;
   /// Name of every state
   public enum STATE
   {
    IDLE,
    ROAMING,
    BATTLE,
    CHASING,
     ATTACK//อยู่ในระยะให้ตี
   }
    /// <summary>
    /// Order of execution
    /// </summary>
   public enum EVENT
   {
        ENTER,
        UPDATE,
        EXIT
   }
   public STATE Name;

   protected EVENT Stage;
   protected Enemy EnemyClass;
   protected NavMeshAgent Agent;
   protected State NextState;
   public  State(Enemy enemy, NavMeshAgent agent)
   {
        EnemyClass = enemy;
        Agent = agent;

        Stage = EVENT.ENTER;
   }

   public virtual void Enter()
   {
        Stage = EVENT.UPDATE;
   }
   public virtual void Update()
   {
        Stage = EVENT.UPDATE;
   }
   /// <summary>
   ///  What to do on EXit this state
   /// </summary>
   public virtual void Exit()
   {
        Stage = EVENT.UPDATE;
   }

   public State Process()
   {
        if(Stage == EVENT.ENTER)
        {
            Enter();
        }
        if(Stage == EVENT.UPDATE)
        {
            Update();
        }
        if(Stage == EVENT.EXIT)
        {
            Exit();
            OnstateChanged?.Invoke();

            return NextState;
        }
        return this;
   }
}
