using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    void Awake()
    {
        current = this;
    }

    public event Action onEnemyDie;
    public event Action onPlayerTakeDamage;

    public void Die()
    {
        onEnemyDie?.Invoke();
    }

    public void PlayerTakeDamage()
    {
        onPlayerTakeDamage.Invoke();
    }
}
