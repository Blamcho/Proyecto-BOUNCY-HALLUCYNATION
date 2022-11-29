using UnityEngine;
using System.Collections;

public class PowerUpJump : MonoBehaviour
{
    [SerializeField] private float _thrust = 5;
    [SerializeField] private float _resetTime = 5;
    [SerializeField] private MeshRenderer _powerUpVisuals = null;
    [SerializeField] private Collider _collider = null;

    private JumpController _jumpController = null;
    private float _previousJumpStrength = default;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        _collider.enabled = false;//Desactiva solamente el MeshRender
        _powerUpVisuals.enabled = false; 
        _jumpController = other.gameObject.GetComponent<JumpController>();
        _previousJumpStrength = _jumpController.JumpStrength;
        _jumpController.ChangeJumpStrength(_thrust);
        StartCoroutine(ResetPowerUp());
    }

    private IEnumerator ResetPowerUp()
    {
        while (true) //Poner siclo while 
        {
            yield return new WaitForSeconds(_resetTime);
            _jumpController.ChangeJumpStrength(_previousJumpStrength);
        }
  
    }
}
