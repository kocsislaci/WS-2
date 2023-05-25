using UnityEngine;

public class DebuggingExample : MonoBehaviour
{
    void Start()
    {
        // We can print to the console on various level of severity

        Debug.Log("Log");
        Debug.LogWarning("Warning!");
        Debug.LogError("Error!");
        Debug.LogAssertion("Assertion");
        
        // we can print exact exceptions
        var exception = new System.Exception();
        Debug.LogException(exception);
        
        // additionally we can create debugging drawings in the scene (not visible by the in-game camera)
        // finite
        Debug.DrawLine(Vector3.up, Vector3.left + Vector3.up, Color.red, 10.0f);
        // infinite
        Debug.DrawRay(Vector3.up, Vector3.forward * 10 + Vector3.right, Color.cyan, 10.0f);
    }
}
