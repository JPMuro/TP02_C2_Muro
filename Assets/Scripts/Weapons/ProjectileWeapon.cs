using UnityEngine;

public class ProjectileWeapon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("Projectile Created");

        GameObject proj = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        proj.GetComponent<Projectile>().Init(shootPoint.forward);
    }
}