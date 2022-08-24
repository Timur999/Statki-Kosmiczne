using UnityEngine;

namespace Scripts.Abstracts.Interfaces
{
    interface ICollision
    {
        public void OnTriggerEnter(Collider other);
    }
}
