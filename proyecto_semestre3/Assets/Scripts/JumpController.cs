using UnityEngine;
using UnityEngine.EventSystems;
public class JumpController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody _rigidbody = null;
    [SerializeField] private float _thrust = 10f;
    [SerializeField] private bool _isGrounded = true;
    public float JumpStrength => _thrust;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            Jump();
        }
    }

    public void TryJump()
    {
        if (_isGrounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        _isGrounded = false;
        _rigidbody.AddForce(0, _thrust, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    public void ChangeJumpStrength(float newStrength)
    {
        _thrust = newStrength;
    }


    public void OnJumpAttempt()
    {
        TryJump();
    }

}


