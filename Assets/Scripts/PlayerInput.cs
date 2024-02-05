using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private bool pressRight;
    private bool pressLeft;
    private bool pressUp;
    private bool pressDown;

    [Header("Move Control")]
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float initialMoveSpeed = 0f;
    [SerializeField] private float initialJumpForce = 0f;

    private float moveSpeed = 0f;
    private float jumpFOrce = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pressRight = false;
        pressLeft = false;
        pressUp = false;
        pressDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            pressRight = true;
        } else if (Input.GetKey(KeyCode.A)) {
            pressLeft = true;
        }
        if (Input.GetKey(KeyCode.W)) {
            pressUp = true;
        } else if (Input.GetKey(KeyCode.S)) {
            pressDown = true;
        }

        moveSpeed = initialMoveSpeed * 1;
    }

    void FixedUpdate() {
        if (pressRight) {
            rb2d.AddForce(new Vector3(moveSpeed, 0, 0));
        }
        if (pressLeft) {
            rb2d.AddForce(new Vector3(-moveSpeed, 0, 0));
        }
        if (pressUp) {
            rb2d.AddForce(new Vector3(0, moveSpeed, 0));
        }
        if (pressDown) {
            rb2d.AddForce(new Vector3(0, -moveSpeed, 0));
        }
        //
    }
}
