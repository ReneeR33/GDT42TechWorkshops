using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public float timeInvincible;

    private bool isInvincible;
    private float timeLeftInvincible;


    public UnityEvent onHealthChanged;
    public Animator animator;

    private void Start()
    {
        if (currentHealth > maxHealth) currentHealth = maxHealth;
        isInvincible = false;
    }
    
    public void Damage(int value)
    {
        if (!isInvincible)
        {
            currentHealth -= value;

            if (currentHealth < 0)
            {
                currentHealth = 0;
                FindObjectOfType<GameManager>().EndGame();
            }
            onHealthChanged.Invoke();
            isInvincible = true;
            animator.SetBool("isInvincible", true);
            timeLeftInvincible = timeInvincible;
            Debug.Log(currentHealth);
        }
    }
    void Update()
    {
        if (isInvincible)
        {
            timeLeftInvincible -= Time.deltaTime;
            if (timeLeftInvincible < 0)
            {
                isInvincible = false;
                animator.SetBool("isInvincible", false);
            }
                
        }
    }
}
