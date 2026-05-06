using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public CarStats stats;
    public CarController controller;

    public TMP_Text healthText;
    public Slider fuelBar;
    public TMP_Text speedText;

    void Update()
    {
        fuelBar.value = stats.fuel / stats.maxFuel;

        speedText.text = "Velocidad: " + Mathf.Round(controller.GetSpeed());
        healthText.text = "Vida: " + Mathf.Round(stats.health);
    }
}