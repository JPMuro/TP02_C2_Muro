using UnityEngine;

public class CarStats : MonoBehaviour
{
    public float fuel = 100f;
    public float maxFuel = 100f;

    public float health = 100f;
    public float maxHealth = 100f;

    public float fuelConsumption = 5f;

    public bool HasFuel => fuel > 0f;

    void Update()
    {
        ConsumeFuel();
    }

    void ConsumeFuel()
    {
        float moveInput = Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical"));

        if (moveInput > 0.1f && fuel > 0f)
        {
            fuel -= fuelConsumption * Time.deltaTime;
            fuel = Mathf.Clamp(fuel, 0, maxFuel);
        }
    }

    public void Refuel(float amount)
    {
        fuel += amount;
        fuel = Mathf.Clamp(fuel, 0, maxFuel);
    }

    public void Repair(float amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        health = Mathf.Clamp(health, 0, maxHealth);

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Car destroyed");
        // optional:
        // disable movement, show UI, etc.
        gameObject.SetActive(false);
    }

}