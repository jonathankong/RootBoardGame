using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyrieController : WarriorController
{
    //[SerializeField]
    //private bool isOnGround = true;
    private Rigidbody rb;
    private void Awake()
    {
        faction = new Eyrie(GameObjectEnums.FactionName.Eyrie);
        rb = this.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isOnGround)
        //{
        //    rb.useGravity = false;
        //}
        //else
        //{
        //    rb.useGravity = true;
        //}
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.tag == "Ground")
    //    {
    //        isOnGround = true;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.collider.tag == "Ground")
    //    {
    //        isOnGround = false;
    //    }
    //}
}