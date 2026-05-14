using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    private Vector3 direction;

    public void Init(Vector3 dir)
    {
        direction = dir;
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            return;

        Destroy(gameObject);
    }
}