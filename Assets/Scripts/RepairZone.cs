using UnityEngine;

public class RepairZone : MonoBehaviour
{
    public float repairRate = 10f;

    private void OnTriggerStay(Collider other)
    {
        CarStats stats = other.GetComponent<CarStats>();

        if (stats != null)
        {
            stats.currentHealth += repairRate * Time.deltaTime;

            stats.currentHealth = Mathf.Min(stats.currentHealth, stats.config.maxHealth); // Para no pasarse del maximo
        }
    }
}