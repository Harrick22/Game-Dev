using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    [SerializeField] private RectTransform healthBar;

    private float fullWidth;
    private float height;

    private void Awake()
    {
        fullWidth = healthBar.sizeDelta.x;
        height = healthBar.sizeDelta.y;
    }

    public void SetMaxHealth(float health)
    {
        maxHealth = health;
        currentHealth = health;
        UpdateBar();
    }

    public void SetHealth(float health)
    {
        currentHealth = Mathf.Clamp(health, 0, maxHealth);
        UpdateBar();
    }

    private void UpdateBar()
    {
        float percent = currentHealth / maxHealth;
        healthBar.sizeDelta = new Vector2(fullWidth * percent, height);
    }
}
