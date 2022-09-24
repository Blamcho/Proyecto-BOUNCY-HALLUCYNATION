using UnityEngine;
using System.Collections;

public class PowerUpVelocity : MonoBehaviour
{
    [SerializeField] private float _velocity = 10;
    [SerializeField] private float _resetTime = 2;
    [SerializeField] private GameObject _powerUpVisuals = null;
    [SerializeField] private Collider _collider = null;

    private MoveController _moveController = null;
    private float _previousVelocity = default;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        _collider.enabled = false;
        _powerUpVisuals.SetActive(false);

        _moveController = other.gameObject.GetComponent<MoveController>();
        _previousVelocity = _moveController.Velocity;
        _moveController.ChangeVelocity(_velocity);

        StartCoroutine(ResetPowerUp());
    }

    private IEnumerator ResetPowerUp()
    {
        yield return new WaitForSeconds(_resetTime);
        _moveController.ChangeVelocity(_previousVelocity);

        Destroy(gameObject);
    }
}
