using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class DragAndDrop : MonoBehaviour
{
    GameObject target;
    Vector3 screenPosition;
    Vector3 offset;
    UnityEngine.InputSystem.Mouse mouse;
    bool isPickedUp = false;

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        RaycastHit hitInfo;
    //        target = ReturnClickedObject(out hitInfo);
    //        if (target != null)
    //        {
    //            isMouseDragging = true;
    //            Debug.Log("our target position :" + target.transform.position);
    //            //Here we Convert world position to screen position.
    //            screenPosition = Camera.main.WorldToScreenPoint(target.transform.position);
    //            offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
    //        }
    //    }

    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        isMouseDragging = false;
    //    }

    //    if (isMouseDragging)
    //    {
    //        //tracking mouse position.
    //        Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z);

    //        //convert screen position to world position with offset changes.
    //        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offset;

    //        //It will update target gameobject's current postion.
    //        target.transform.position = currentPosition;
    //    }
    //}
    private void Awake()
    {
        mouse = UnityEngine.InputSystem.Mouse.current;
    }

    private void Update()
    {
        if (isPickedUp)
        {
            //Here we Convert world position to screen position.
            //screenPosition = Camera.main.WorldToScreenPoint(target.transform.position);
            var mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mouse.position.x.ReadValue(), mouse.position.y.ReadValue(), Camera.main.gameObject.transform.position.y));
            mousePosition.y += 1;
            target.transform.position = mousePosition;
            
            //offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(mouse.position.x.ReadValue(), mouse.position.y.ReadValue(), Camera.main.gameObject.transform.position.y));
            ////tracking mouse position.
            //Vector3 currentScreenSpace = new Vector3(mouse.position.x.ReadValue(), mouse.position.y.ReadValue(), screenPosition.z);

            ////convert screen position to world position with offset changes.
            //Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offset;

            ////It will update target gameobject's current postion.
            //target.transform.position = currentPosition;
        }
        else if (target != null)
        {
            target.transform.position = new Vector3(target.transform.position.x, target.transform.position.y - 1, target.transform.position.z);
            target = null;
        }
    }

    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject targetObject = null;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3 (mouse.position.x.ReadValue(), mouse.position.y.ReadValue(), 0));
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            targetObject = hit.collider.gameObject;
        }
        return targetObject;
    }

    public void PickUp(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<float>() == 1f);
        Debug.Log(context.performed);
        if (context.performed)
        {
            RaycastHit hitInfo;
            target = ReturnClickedObject(out hitInfo);
            if (target != null)
            {
                isPickedUp = true;
            }
        }
        else
        {
            isPickedUp = false;
        }
        //Debug.Log(context.duration + " " + context.performed);
    }

}
