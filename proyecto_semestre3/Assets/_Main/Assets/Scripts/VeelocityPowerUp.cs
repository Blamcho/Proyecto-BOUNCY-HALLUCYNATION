using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeelocityPowerUp : MonoBehaviour
{
    [SerializeField] private float _velocity = 15;
    [SerializeField] private float _resetTime = 5;
    [SerializeField] private MeshRenderer _powerUpVisuals = default;
    [SerializeField] private Collider _collider = null;

    private MoveController _moveController = null;
    private float _previousVelocity = default;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        _collider.enabled = false;//Desactiva solamente el MeshRender
        _powerUpVisuals.enabled = false;

        _moveController = other.gameObject.GetComponent<MoveController>();
        _previousVelocity = _moveController.Velocity;
        _moveController.ChangeVelocity(_velocity);

        StartCoroutine(ResetPowerUp());
    }

    private IEnumerator ResetPowerUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(_resetTime);
            _moveController.ChangeVelocity(_previousVelocity);
        }



    }
}
