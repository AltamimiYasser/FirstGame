using UnityEngine;

public class PlayerMovments : MonoBehaviour
{
    [SerializeField] float forwardForce = 2000f;
    [SerializeField] float sidewaysForce = 500f;

    Rigidbody rb;
    float horiontal;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horiontal = Input.GetAxis("Horizontal");
        //if (Input.GetKey("d"))
        //{
        //    rightClicked = true;
        //}

        //if (Input.GetKeyUp("d"))
        //{
        //    rightClicked = false;
        //}

        //if (Input.GetKey("a"))
        //{
        //    leftClicked = true;
        //}

        //if (Input.GetKeyUp("a"))
        //{
        //    leftClicked = false;
        //}

    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(horiontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        transform.Translate(horiontal, 0, 0);

        //if (rightClicked)
        //{
        //    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        //if (leftClicked)
        //{
        //    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
    }
}
