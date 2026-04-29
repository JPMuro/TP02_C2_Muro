using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public CarStats stats;
    public CarController controller;

    public Slider healthBar;
    public Slider fuelBar;
    public TMP_Text speedText;

    void Update()
    {
        healthBar.value = stats.currentHealth / stats.config.maxHealth;
        fuelBar.value = stats.currentFuel / stats.config.maxFuel;

        speedText.text = "Velocidad: " + Mathf.Round(controller.GetSpeed());
    }
}