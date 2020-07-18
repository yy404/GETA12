using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private EndManager endManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        endManager = FindObjectOfType<EndManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (endManager.CheckGameActive())
        {
            MovePlayer();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destination"))
        {
            // Debug.Log("Player has reached the destination.");

            endManager.SetReachDest();
        }
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3 (horizontalInput, 0, verticalInput);
        rb.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }
}
