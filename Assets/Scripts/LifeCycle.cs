using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DestroyAfterDelay(2);
    }

    public void DestroyAfterDelay(float delay)
    {
        Invoke("DestroyObject", delay);
    }

    private void DestroyObject()
    {
        Debug.Log("DestroyObject");
        Destroy(gameObject);
    }
}
