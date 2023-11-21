using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _currentHealth;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = maxHealth;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="source"></param>

    public void TakeDamage(float amount, Pawn source)
    {
        _currentHealth = _currentHealth - amount;
        _currentHealth = Mathf.Clamp( _currentHealth, 0, maxHealth );
        Debug.Log(source.name + " did " + amount + " damage to" + gameObject.name);
        Debug.LogFormat("{0} did {1} damage to {2}.", source.name, amount, gameObject.name);

        if (_currentHealth <= 0 )
        {
            Die(source);
        }
    }

    public void Heal(float amount, Pawn source)
    {
        _currentHealth = _currentHealth + amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, maxHealth);
        

       
    }







    public void Die(Pawn source)
    {
        Debug.Log(source.name + " killed " + gameObject.name);
        Destroy(gameObject);
    }
}
