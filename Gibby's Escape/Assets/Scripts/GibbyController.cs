using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Android.LowLevel;

public class GibbyController : MonoBehaviour
{
    [SerializeField]
    private PlayerController GibbyControls;
    private Rigidbody gibbyRB;
    private Vector3 moveVec;
    
    public float gibbySpeed;
    public float jumpForce;

    public bool isJumping;

    // Start is called before the first frame update
    void Awake()
    {
        gibbyRB = GetComponent<Rigidbody>();
        GibbyControls = new PlayerController();
        GibbyControls.Enable();
        isJumping = false;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveVec = GibbyControls.GibbyControls.Movement.ReadValue<Vector3>();
        gibbyRB.AddForce(new Vector3(moveVec.x, 0, moveVec.z) * gibbySpeed, ForceMode.Force);
        GibbyControls.GibbyControls.Jump.started += _ => GibbyJump();
        JumpingState();
    }

    public void GibbyJump()
    {
        gibbyRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isJumping = true;
    }

    //Gibby's Input States
    public void JumpingState()
    {
        if (isJumping)
        {
            GibbyControls.GibbyControls.Jump.Disable();
        }
        else
        {
            GibbyControls.GibbyControls.Jump.Enable();
        }
    }

   
    //Gibby's Collision Code
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }
}
