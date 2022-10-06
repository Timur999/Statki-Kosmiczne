using Assets.Scripts.Models;
using System.Collections;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField]
    public GameObject Enemy;

    [SerializeField]
    public Player GamePlayer;

    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Enemy, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
   /*         Vector3 v3 = new Vector3(0, 0, 50);
            var playerPosition = GamePlayer.transform.position;*/

             Instantiate(GamePlayer.Bullet, new Vector3(0, 0, 50), Quaternion.identity);
            // StartCoroutine(WhaitSecond());
        }

    }

    IEnumerator WhaitSecond()
    {
        Debug.Log("wait second!!!");
        yield return new WaitForSeconds(1);
        Debug.Log("end!!!");
    }


}
