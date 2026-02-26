using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    public UnityEvent onStateChnaged;
    public float stateChangeInterval = 300f; // 5 minutes in seconds

    void Start()
    {
        StartCoroutine(MinuteLoop());
    }

    IEnumerator MinuteLoop()
    {
        while (true) 
        {
            yield return new WaitForSeconds(stateChangeInterval);
            onStateChnaged.Invoke();

        }
    }

}
