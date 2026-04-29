using UnityEngine;

[CreateAssetMenu(fileName = "CarConfig", menuName = "SO/Car Configuration")]
public class CarConfigurationSO : ScriptableObject
{
    public float maxSpeed;
    public float acceleration;
    public float friction;
    public float maxHealth;
    public float maxFuel;
}