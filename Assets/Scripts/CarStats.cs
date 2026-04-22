using UnityEngine;

public class CarStats : MonoBehaviour
{
    public CarConfigurationSO config;
    public float health;
    public float fuel;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        health = config.maxHealth;
        fuel = config.maxFuel;
    }

    void Update()
    {
        if (rb.linearVelocity.magnitude > 1f)
        {
            fuel -= Time.deltaTime * 2f;
        }
        fuel = Mathf.Clamp(fuel, 0, config.maxFuel);
    }

    void OnCollisionEnter(Collision collision)
    {
        float damage = rb.linearVelocity.magnitude * 2f;
        health -= damage;

        if (health <= 0)
        {
            Time.timeScale = 0f;
            gameObject.SetActive(false);
        }
    }

    public void Repair(float amount)
    {
        health += amount * Time.deltaTime;
        health = Mathf.Clamp(health, 0, config.maxHealth);
    }

    public void Refuel(float amount)
    {
        fuel += amount * Time.deltaTime;
        fuel = Mathf.Clamp(fuel, 0, config.maxFuel);
    }
}