using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RequiredComponent)), Tooltip("When we added this script to the game object, Rigidbody is also added. If we want to remove the `RequiredComponent` component, we will not be able to it.")]
public class InspectorAttributesExample : MonoBehaviour
{
    [Header("Numbers"), Tooltip(tooltip: "Tooltip, in case you need any more explanation")]
    [Header("With input fields")]
    [SerializeField] private int integer;
    [SerializeField, InspectorName("renamedInteger")] private int secondInteger;
    [SerializeField] private float floatingPointNumber;
    [HideInInspector] public int hiddenInteger;
    [Header("Ranged")]
    [SerializeField, Range(0, 10)] private int ragedInteger;
    [SerializeField, Range(-0.5f, 0.5f)] private float rangedFloatingPointNumber;
    [Header("Limited"),
    SerializeField][Min(0)] private int minZeroInteger;
    [SerializeField, Min(0), Space(100)] private float minZeroFloat;
    
    [Header("Strings")]
    [SerializeField] private string @string;
    [SerializeField] private string @otherString;
    [SerializeField, Multiline(2)] private string @intermediateLongString;
    [SerializeField, TextArea(minLines: 3, maxLines: 30)] private string @reallyLongString;


    [Header("Data structures")]
    [SerializeField] private CompositeStruct compositeStruct = new();
    [SerializeField] private Dictionary<Team, string> _teamDictionary = new();
}

[System.Serializable]
internal enum Team
{
    Red, 
    Blue,
    Green,
    Yellow,
}

[System.Serializable]
internal struct CompositeStruct
{
    [SerializeField]
    private int integer;

    [SerializeField]
    private Team team;
    
    [SerializeField]
    private List<string> listOfStrings;

    public CompositeStruct(
        int integer,
        Team team,
        List<string> listOfStrings
    ) : this()
    {
        this.integer = integer;
        this.team = team;
        this.listOfStrings = listOfStrings;
    }
}
