using Scripts.Abstracts.Interfaces;
using UnityEngine;

namespace Scripts.Abstracts.Classes
{
    class Destroyable : MonoBehaviour, ICollision
    {
        public GameObject Explosion;

        public void OnTriggerEnter(Collider other)
        {
            Debug.Log(gameObject.tag);
            Debug.Log(other.tag);
            var exp = Instantiate(Explosion, transform.position, Quaternion.identity);
            exp.transform.localScale = transform.localScale;
            Destroy(gameObject);
        }

    }
}
