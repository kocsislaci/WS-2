using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class CoroutineExample : MonoBehaviour
{
    [SerializeField] private int iterationNumber = 10;
    private int _actualIterationProgress = 0;
    [SerializeField] private float period = 2;
    
    void Start()
    {
        Debug.Log($"Coroutine started");
        StartCoroutine(MyCoroutine(iterationNumber, period));
    }

    private IEnumerator MyCoroutine(int iterationTimes, float period)
    {
        while (_actualIterationProgress < iterationTimes)
        {
            Debug.Log($"Coroutine iteration: {_actualIterationProgress}");
            _actualIterationProgress++;
            yield return new WaitForSeconds(period);
        }
        Debug.Log($"Coroutine finished");
    }
}
