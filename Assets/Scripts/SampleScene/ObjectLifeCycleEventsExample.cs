using UnityEngine;

// default access modifier of root elements (class, struct, record, & etc.) = internal
internal class ObjectLifeCycleEventsExample : MonoBehaviour
{
    // default access modifier of members = private

    // Awake is called when the script instance is being loaded.
    // Use Awake to initialize variables or states before the application starts.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // This function is called just after the object is enabled.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start");
    }

    // FixedUpdate is often called more frequently than Update.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    
    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Update");
    }

    // LateUpdate is called once per frame, after Update has finished.
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    // This function is called on all game objects before the application is quit.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // This function is called when the behaviour becomes disabled or inactive.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    
    // This function is called after all frame updates for the last frame of the object’s existence
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
