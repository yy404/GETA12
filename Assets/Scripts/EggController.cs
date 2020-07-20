using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public float force;

    private Rigidbody rb;
    private int flagValue;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        flagValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(rb.velocity.magnitude);
    }

    void FixedUpdate()
    {
        if (flagValue > 0)
        {
            rb.AddForce(Vector3.left * force);
        }
        else if (flagValue < 0)
        {
            rb.AddForce(Vector3.right * force);
        }
    }

    public void UpdateFlag(float val)
    {
        if (val > 0)
        {
            flagValue = 1;
        }
        else if (flagValue < 0)
        {
            flagValue = -1;
        }
    }
    public void ResetFlag()
    {
        flagValue = 0;
    }
}
