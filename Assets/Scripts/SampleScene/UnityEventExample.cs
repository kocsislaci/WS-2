using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
    [SerializeField] private UnityEvent myEvent;
    
    private void OnEnable()
    {
        myEvent.AddListener(Print);
    }

    private void OnDisable()
    {
        myEvent.RemoveListener(Print);
    }
    
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            myEvent?.Invoke();
        }
    }
    
    private void Print()
    {
        Debug.Log($"Invoked event");
    }
}
