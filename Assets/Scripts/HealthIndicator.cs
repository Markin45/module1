using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthIndicator : MonoBehaviour
{
    public TextMeshProUGUI textField;
    Health health;
    float displayedHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        displayedHealth = health.Current - 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float value = health.Current;
        if (value < 0) value = 0;
        if (Mathf.Abs(displayedHealth - value) >= 0.00001f) {
            if (value == 0)
            {
                textField.text = "";
            }
            else
            {
                displayedHealth = value;
                textField.text = $"{value}";
            }
        }
    }
}
