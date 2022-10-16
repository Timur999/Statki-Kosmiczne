using System;
using UnityEngine;
using Scripts.Helpers;

public class ShipMove : MonoBehaviour
{
    private Rigidbody rigidbody;

    public int Speed = 5;

    // Update is called once per frame
    void Update()
    {
        Move2();
    }

 /*   void FixedUpdate()
    {

    }*/

    private void Move()
    {
        Debug.LogWarning(Input.GetAxis("Horizontal"));

        if (MoveHelper.ShouldChangePosition(MoveHelper.PlayersDirectionKeys, out var keyCode))
        {
            transform.position += MoveHelper.GetDirection(keyCode) * Time.deltaTime * Speed;
        }
    }


    private void Move2()
    {
        Debug.LogWarning(Input.GetAxis("Horizontal"));


        var verctor = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (MoveHelper.ShouldChangePosition(MoveHelper.PlayersDirectionKeys, out var keyCode))
        {
            transform.position += verctor * Time.deltaTime * Speed;
        }
    }
}
