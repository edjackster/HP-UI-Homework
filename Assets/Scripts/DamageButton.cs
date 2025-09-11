using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private HealthSystem _healthSystem;
    
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Attack);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Attack);
    }

    private void Attack()
    {
        _healthSystem.TakeDamage(_damage);
    }
}
