using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CollisionDamage : MonoBehaviour
{
    public CarStats stats;
    public float damageMultiplier = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            return;

        if (collision.gameObject.CompareTag("Wall"))
        {
            float impact = collision.relativeVelocity.magnitude;
            float damage = impact * damageMultiplier;

            if (damage > 1f)
            {
                stats.TakeDamage(damage);
            }
        }
    }
}