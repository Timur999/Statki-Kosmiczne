using UnityEngine;
using Scripts.Helpers;

public class EnemyMove : MonoBehaviour
{
    private Vector3 Direction;

    public float Speed = 20;
/*
    [SerializeField]
    public GameObject Explosion;*/

    private static Vector3[] EnemyDirections = { Vector3.back, Vector3.back + Vector3.right, Vector3.back + Vector3.left };

    void Start()
    {
        Debug.Log("Start Enemy");
        gameObject.transform.position = MoveHelper.RandomPosition(90, 5, 60);
        Direction = MoveHelper.RandomDirection(EnemyDirections);
        Debug.Log(Direction.x + ", " + Direction.y + ", " + Direction.z);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnBecameInvisible()
    {
        Debug.Log("OnBecameInvisible");
        gameObject.transform.position = MoveHelper.RandomPosition(90, 5, 60);
        Direction = MoveHelper.RandomDirection(EnemyDirections);
        Debug.Log(Direction.x + ", " + Direction.y + ", " + Direction.z);
    }

/*    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        Debug.Log("OnTriggerEnter");
        var exp = Instantiate(Explosion, transform.position, Quaternion.identity);
        exp.transform.localScale = transform.localScale;
        Destroy(gameObject);
    }*/

    private void Move()
    {
        transform.position += Direction * Time.deltaTime * Speed;
    }
}