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

    public bool isJumping;

    // Start is called before the first frame update
    void Awake()
    {
        gibbyRB = GetComponent<Rigidbody>();
        GibbyControls = new PlayerController();
        GibbyControls.Enable();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveVec = GibbyControls.GibbyControls.Movement.ReadValue<Vector3>();
        Vector3 gibbyMoveInput = new Vector3(moveVec.x, 0, moveVec.z);
        gibbyRB.MovePosition(transform.position + gibbyMoveInput * gibbySpeed * Time.deltaTime);

    }

}
