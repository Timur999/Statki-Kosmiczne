using Scripts.Abstracts.Classes;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Bullet : Destroyable
    {
        public Player Player;
        public override void OnTriggerEnter(Collider other)
        {
            if(other.tag != "Player")
            {
                base.OnTriggerEnter(other);
            }
        }

        public void Start()
        {
            Vector3 v3 = new Vector3(0, 0, 15);
            this.transform.position = Player.transform.position + v3;
        }

        public void Update()
        {
            this.transform.position += Vector3.forward * Time.deltaTime * 10;
        }
    }
}
