using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float power = 500f;
    [SerializeField] private float damage;
    private Rigidbody2D _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.AddForce(transform.right*power);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damage);
            GameEvents.current.PlayerTakeDamage();
        }
    }

    private void OnDisable()
    {
        GameEvents.current.Die();
    }
}
