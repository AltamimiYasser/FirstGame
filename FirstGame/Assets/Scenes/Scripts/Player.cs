using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float forwardForce = 2000f;
    [SerializeField] float sidewaysForce = 500f;

    Rigidbody rb;
    bool rightClicked;
    bool leftClicked;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();        
    }

    private void Update()
    {
        if (Input.GetKey("d"))
        {
            rightClicked = true;
        }

        if (Input.GetKeyUp("d"))
        {
            rightClicked = false;
        }

        if (Input.GetKey("a"))
        {
            leftClicked = true;
        }

        if (Input.GetKeyUp("a"))
        {
            leftClicked = false;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (rightClicked)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (leftClicked)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
