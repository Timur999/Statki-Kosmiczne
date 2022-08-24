using UnityEngine;
using Scripts.Helpers;

public class CameraMove : MonoBehaviour
{
    public float Speed = 1f;
    // Update is called once per frame
    void Update()
    {
        if (MoveHelper.ShouldChangePosition(MoveHelper.CameraDirectionKeys, out var keyCode))
        {
            Debug.Log(Input.GetKey(KeyCode.Space));
            if (Input.GetKey(KeyCode.Space))
            {
                transform.rotation = transform.rotation;
                var x = transform.rotation.x;
                transform.rotation = MoveHelper.GetQuaternion(keyCode);
            }
            else
            {
                transform.position = transform.position + MoveHelper.GetDirection(keyCode) * Time.deltaTime * Speed;
            }
        }
    }


}
