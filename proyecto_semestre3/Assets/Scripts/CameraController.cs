using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player = default;
    [SerializeField]  private Vector3 _position = default;
    void Start()
    {
        _position = transform.position - Player.transform.position;
    }

    void Update()
    {
        transform.position = Player.transform.position + _position;
  
    }
}
