using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float currentSpeed;

    public float walkingSpeed = 10f;
    public float runningSpeed = 20f;

    private float moveX;
    private float moveZ;

    public float gravity = -0.5f;
    public float jumpSpeed = 0.8f;
    private float baseLineGravity;

    private Vector3 move;

    public CharacterController characterController;
    private Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = walkingSpeed;
        baseLineGravity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        moveZ = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;


        move = transform.right * moveX +
               transform.up * gravity +
               transform.forward * moveZ;

        characterController.Move(move);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runningSpeed;
        }
        else
        {
            currentSpeed = walkingSpeed;
        }

        if (characterController.isGrounded == true && Input.GetButtonDown("Jump"))
        {
            gravity = baseLineGravity;

            gravity *= -jumpSpeed;
        }

        if (gravity > baseLineGravity)
        {
            gravity -= 1 * Time.deltaTime;
        }

    }

}