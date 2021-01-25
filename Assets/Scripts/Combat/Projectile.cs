using UnityEngine;
using UnityEngine.Events;

public class Projectile : MonoBehaviour
{
    [SerializeField] private UnityEvent onHit;
    [SerializeField] private ParticleSystem onWallHit;
    [SerializeField] private ParticleSystem onEnemyHit;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float damage = 1;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            onHit.Invoke();
            Instantiate(onEnemyHit,transform.position, Quaternion.identity);
            other.gameObject.GetComponent<Health>().TakeDamage(damage);
            
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Wall"))
        {
            Instantiate(onWallHit,transform.position, Quaternion.identity);
            Destroy(gameObject);
            onHit.Invoke();
        }
    }
}
