using UnityEngine;

public class CarStats : MonoBehaviour
{
    public CarConfigurationSO config;

    public float currentHealth;
    public float currentFuel;

    private void Start()
    {
        currentHealth = config.maxHealth;
        currentFuel = config.maxFuel;
    }

    private void Update()
    {
        if (currentFuel > 0)
        {
            currentFuel -= Time.deltaTime * 2f;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        currentHealth = Mathf.Max(0, currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Vehículo destruido :(");
            Time.timeScale = 0f;
        }
    }

    public void Repair(float amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, config.maxHealth);
    }

    public void Refuel(float amount)
    {
        currentFuel = Mathf.Min(currentFuel + amount, config.maxFuel);
    }
}