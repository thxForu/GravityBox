using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float healthPoint;

    private float _currentHealthPoint;

    private void Start()
    {
        _currentHealthPoint = healthPoint;
    }

    public void TakeDamage(float damage)
    {
        _currentHealthPoint -= damage;
        if (_currentHealthPoint <= 0)
        {
            Die();
        }
    }
    
    public float GetHealthPoints()
    {
        return _currentHealthPoint;
    }
    public float GetFraction()
    {
        return _currentHealthPoint/healthPoint;
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}

