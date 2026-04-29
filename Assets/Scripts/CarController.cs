using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    public CarConfigurationSO config;

    private Rigidbody rb;
    private float currentSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 force = transform.forward * v * config.acceleration;
        rb.AddForce(force);

        transform.Rotate(Vector3.up * h * 100f * Time.fixedDeltaTime);

        if (rb.linearVelocity.magnitude > config.maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * config.maxSpeed;
        }

        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, Vector3.zero, config.friction * Time.fixedDeltaTime);

        currentSpeed = rb.linearVelocity.magnitude;
    }

    public float GetSpeed()
    {
        return currentSpeed;
    }
}