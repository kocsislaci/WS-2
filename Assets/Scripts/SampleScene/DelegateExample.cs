using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // type definition (template)
    private delegate void MyDelegate(string message);
    
    // delegate member creation
    [SerializeField] private MyDelegate _myDelegate;

    private void OnEnable()
    {
        Debug.Log("Add delegated function");
        // add the function to the delegate instance
        _myDelegate += Printer;
    }

    private void OnDisable()
    {
        Debug.Log("Remove delegated function");
        // remove the function from the delegate instance
        _myDelegate -= Printer;
    }

    private void Start()
    {
        Debug.Log("Trigger delegated function");
        // trigger the stored functions of the delegate
        _myDelegate("Message sent to delegated functions");
    }

    private void Printer(string toBePrinted)
    {
        Debug.Log("Printer function");
        Debug.Log(toBePrinted);
    }
}
