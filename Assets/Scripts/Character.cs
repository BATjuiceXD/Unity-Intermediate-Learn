using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]protected Animator _animator;
    [SerializeField]protected float _walkSpeed = 1f;
    [SerializeField]protected float _runSpeed = 2f;
    [SerializeField]protected float _jumpForce = 10f;
    [SerializeField] protected Rigidbody _rigidbody;
    [SerializeField] protected int _maxhealth =20;
    [SerializeField] protected int Damage=10;
    [SerializeField] protected int _atkdamage=10;
    protected int _health =20;
    protected float _speed;
    protected bool _isRunning = false;
    protected virtual void Awake()
    {
        _speed = _walkSpeed;
        _health = _maxhealth;
    }
    public virtual void Attack(Character target)
    {
        target.TakeDamage(_atkdamage);
    }
    public virtual void TakeDamage(int Damage)
    {
        _health -= Damage;
        if(_health <=0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }

}
