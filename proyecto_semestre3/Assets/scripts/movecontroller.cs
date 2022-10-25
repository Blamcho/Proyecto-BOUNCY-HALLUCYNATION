using UnityEngine;
using UnityEngine.EventSystems;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float _velocity = 10f;
    [SerializeField] private float _imput = default;
    private bool _isPressed = default;
    public float Velocity => _velocity;

    private void Start()
    {
        _isPressed = false;
    }

    void Update()
    {
        transform.position += Vector3.forward * _imput * _velocity * Time.deltaTime;

        
        if (Input.GetKey(KeyCode.A)&& _isPressed)
        {
            transform.position += Vector3.back * _velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)&& _isPressed)
        {
            transform.position += Vector3.forward * _velocity * Time.deltaTime;
        }
         
    }
     
    public void ChangeVelocity(float newVelocity)
    {
        _velocity = newVelocity;
    }

    public void moveleft()
    {
        _imput = -1;
    }

    public void moveright()
    {
        _imput = 1;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isPressed = false;
    }

 
    public void resetleft()
    {
        if (_imput == -1)
        {
            _imput = 0;
        }
        else
        {
            return;
        }
    }
    
    public void resetright()
    {
        if (_imput == 1)
        {
            _imput = 0;
        }
        else
        {
            return;
        }
    }
}
