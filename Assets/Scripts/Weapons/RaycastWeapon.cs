using UnityEngine;

public class RaycastWeapon : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;
    public Camera cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You shoot");
            Shoot();
        }
    }

    void Shoot()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, range))
        {
            IDamageable dmg = hit.collider.GetComponent<IDamageable>();

            if (dmg != null)
            {
                dmg.TakeDamage(damage);
            }
        }
    }
}