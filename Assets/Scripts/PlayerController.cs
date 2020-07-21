using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float force;
    public bool defultControlType;
    public Animator chickenFrontAnim;
    public Animator chickenBackAnim;

    private Rigidbody rb;
    private EndManager endManager;
    private AudioPlayer audioPlayer;
    private EggController eggController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        endManager = FindObjectOfType<EndManager>();
        audioPlayer = FindObjectOfType<AudioPlayer>();
        eggController = FindObjectOfType<EggController>();
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

    // private void OnCollisionEnter(Collision collision)
    // {
    // }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3 (horizontalInput, 0, verticalInput);
        if (defultControlType == false)
        {
            Vector3 horizontalMovement = new Vector3 (horizontalInput, 0, 0);
            Vector3 verticalMovement = new Vector3 (0, 0, verticalInput);
            rb.MovePosition(transform.position + horizontalMovement * speed * Time.fixedDeltaTime);
            rb.AddForce(verticalMovement * force);
        }
        else
        {
            Vector3 dummyHorizontalMovement = new Vector3 (-verticalInput, 0, 0);
            Vector3 dummyVerticalMovement = new Vector3 (0, 0, horizontalInput);
            rb.MovePosition(transform.position + dummyHorizontalMovement * speed * Time.fixedDeltaTime);
            rb.AddForce(dummyVerticalMovement * force);
        }

        if (movement.magnitude > 0)
        {
            chickenFrontAnim.SetBool("Walk", true);
            chickenBackAnim.SetBool("Walk", true);
            audioPlayer.PlayFootstep();
            eggController.UpdatePosiX(transform.position.x);
        }
        else
        {
            chickenFrontAnim.SetBool("Walk", false);
            chickenBackAnim.SetBool("Walk", false);
            audioPlayer.StopPlay();
        }
    }
}
