using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField] private float speed = 2f;
    [SerializeField] private float turnSpeed = 45f;
    [SerializeField] private float boostedSpeed = 5f; // Vitesse boostée
    private float currentSpeed;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GetComponent<Rigidbody>();
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = Vector3.forward * Input.GetAxis("Vertical") * currentSpeed;
        transform.Translate(velocity * Time.deltaTime);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed);
        animator.SetFloat("Speed", velocity.z);

        if (Input.GetKeyDown(KeyCode.R))
        {
            currentSpeed = boostedSpeed; // Passe à la vitesse boostée
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            currentSpeed = speed;



        }
    }
}
