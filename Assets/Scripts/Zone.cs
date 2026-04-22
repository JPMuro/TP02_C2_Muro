using UnityEngine;

public class Zone : MonoBehaviour
{
    public enum ZoneType { Repair, Fuel }
    public ZoneType type;

    void OnTriggerStay(Collider other)
    {
        CarStats stats = other.GetComponent<CarStats>();
        if (stats == null) return;

        if (type == ZoneType.Repair)
            stats.Repair(10f);

        if (type == ZoneType.Fuel)
            stats.Refuel(15f);
    }
}