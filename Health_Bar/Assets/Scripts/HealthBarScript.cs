using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public GameObject player;
    public Text HealthBarText;

    private Slider slider;
    private Health playerHealth;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }
    
    public void OnHealthChanged()
    {
        HealthBarText.text = player.GetComponent<Health>().currentHealth.ToString();
        slider.value = player.GetComponent<Health>().currentHealth;
    }
}
