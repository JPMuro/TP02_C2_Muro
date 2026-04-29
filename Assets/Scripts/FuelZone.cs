using UnityEngine;

public class FuelZone : MonoBehaviour
{
    public float fuelRate = 10f;

    private void OnTriggerStay(Collider other)
    {
        CarStats stats = other.GetComponent<CarStats>();

        if (stats != null)
        {
            stats.Refuel(fuelRate * Time.deltaTime);
        }
    }
}