using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpv = 0.4f;
    public  Rigidbody rb;
    public float thrust = 10f;
    bool m_isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_isGrounded = true;
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space )&&m_isGrounded == true )
        {
            jump();
        }
    }

    public void jump()

    {
        m_isGrounded=false;
        rb.AddForce(0, thrust,0, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))

        {
            m_isGrounded = true;
        }
    }

}
