using TMPro;
using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected HealthSystem _healthSystem;

    private void OnEnable()
    {
        UpdateView(_healthSystem.HealthPoints);
        _healthSystem.HealthChanged += UpdateView;
    }

    private void OnDisable()
    {
        _healthSystem.HealthChanged -= UpdateView;
    }

    protected abstract void UpdateView(int health);
}
