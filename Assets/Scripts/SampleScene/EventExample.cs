using UnityEngine;

public class EventExample : MonoBehaviour
{
    private int _actualNumber = 0;
    
    // type definition (template)
    private delegate void ButtonDelegate(int number);
    
    // delegate member creation
    [SerializeField] private static event ButtonDelegate OnButtonClicked;

    private void OnEnable()
    {
        OnButtonClicked += Print;
    }

    private void OnDisable()
    {
        OnButtonClicked -= Print;
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            _actualNumber++;
            OnButtonClicked?.Invoke(_actualNumber);
        }
    }

    private void Print(int number)
    {
        Debug.Log($"Invoked event {number} times.");
    }
}
