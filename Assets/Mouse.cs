using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouse : MonoBehaviour
{
    ////[SerializeField]
    //public MouseControls _mouseControls;
    //// Start is called before the first frame update
    //private void OnEnable()
    //{
    //    _mouseControls.Mouse.Move.performed += MouseMove;
    //    _mouseControls.Mouse.Move.Enable();
    //}

    //private void OnDisable()
    //{
    //    _mouseControls.Mouse.Move.performed -= MouseMove;
    //    _mouseControls.Mouse.Move.Disable();
    //}

    void Start()
    {

    }

    public void Move(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());
    }


    public void PickUp(InputAction.CallbackContext context)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
