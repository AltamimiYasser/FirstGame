using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
