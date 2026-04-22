using UnityEngine;

[CreateAssetMenu(fileName = "CarConfig", menuName = "Car/Config")]
public class CarConfigurationSO : ScriptableObject
{
    public float maxSpeed = 20f;
    public float acceleration = 10f;
    public float turnSpeed = 100f;
    public float maxHealth = 100f;
    public float maxFuel = 100f;
}