using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class HealthTextView : HealthView
{
    private TMP_Text _healthText;

    private void Awake()
    {
        _healthText =  GetComponent<TMP_Text>();
    }

    protected override void UpdateView(int health)
    {
        _healthText.text = $"{health}/{HealthSystem.MaxHealthPoints}";
    }
}
