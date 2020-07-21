using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public float force;
    public float resistRatio;

    private Rigidbody rb;
    private float xPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(rb.velocity.magnitude);
    }

    void FixedUpdate()
    {
        // float deltaVal = Mathf.Abs(xPosition - transform.position.x);
        if (xPosition < transform.position.x)
        {
            rb.AddForce(Vector3.left * force);
        }
        else if (xPosition > transform.position.x)
        {
            rb.AddForce(Vector3.right * force);
        }

        if (rb.velocity.x > 0)
        {
            rb.AddForce(Vector3.left * force * resistRatio);
        }
        else if (rb.velocity.x < 0)
        {
            rb.AddForce(Vector3.right * force * resistRatio);
        }
    }

    public void UpdatePosiX(float xVal)
    {
        xPosition = xVal;
    }
}
