using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int speed;
    public FixedJoystick joystick;
    [SerializeField] private int maxX;
    [SerializeField] private int minX;
    [SerializeField] private int maxZ;
    [SerializeField] private int minZ;
    public Animator animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        rb.velocity = direction * speed;

        bool isMoving = direction.magnitude > 0.1f;
        animator.SetBool("isWalking", isMoving);
        if(isMoving)
        {
            transform.forward = direction;
        }

        Vector3 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x,minX,maxX);
        pos.z = Mathf.Clamp(pos.z,minZ,maxZ);
        rb.position = pos;  

    }


}
