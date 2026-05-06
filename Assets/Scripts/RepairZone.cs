using UnityEngine;

public class RepairZone : MonoBehaviour
{
    public float repairRate = 10f;

    private void OnTriggerStay(Collider other)
    {
        CarStats stats = other.GetComponent<CarStats>();

        if (stats != null)
        {
            stats.Repair(repairRate * Time.deltaTime);
        }
    }
}