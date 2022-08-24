using UnityEngine;
using UnityEngine.UI;

public class GameInspector : MonoBehaviour
{   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DisplayValue", 1f, 0.5f);
    }

    private void DisplayValue()
    {
        SetValue(CountFrames(Time.deltaTime));
    }

    private static float CountFrames(float deltaTime)
    {
        return 1 / deltaTime;
    }

    private void SetValue(float value)
    {
        var text = gameObject.GetComponent<Text>();
        text.text = $"FPS: {value}";
    }

    // Update is called once per frame
/*    void Update()
    {
        UpdateExecutionCounter();
    }

    private static void UpdateExecutionCounter()
    {
        DateTime dateTime;
        int secend = 0;
        int counter = 0;
        dateTime = DateTime.Now;
        var a = dateTime.Second;
        if (secend < a)
        {
            Debug.Log(counter);
            secend = a;
            counter = 0;
        }

        counter++;
    }*/
}
