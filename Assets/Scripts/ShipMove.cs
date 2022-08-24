using System;
using UnityEngine;
using Scripts.Helpers;

public class ShipMove : MonoBehaviour
{
    public int Speed = 5;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(MoveHelper.ShouldChangePosition(MoveHelper.PlayersDirectionKeys, out var keyCode))
        {
            transform.position += MoveHelper.GetDirection(keyCode) * Time.deltaTime * Speed;
        }
    }
}
