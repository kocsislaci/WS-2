using UnityEngine;

public class ColliderEventsExample : MonoBehaviour
{
    // GameObject with a collider
    // collision detection events
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objects"))
        {
            Debug.Log("CollisionEnter with: " + other.gameObject.name);
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objects"))
        {
            Debug.Log("CollisionStay with: " + other.gameObject.name);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objects"))
        {
            Debug.Log("CollisionExit with: " + other.gameObject.name);
        }
    }
    //***
    
    // GameObject with a collider set to trigger,no collision)
    // proximity trigger events
    //[RequireComponent(Collider)]
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objects"))
        {
            Debug.Log("TriggerEnter with: " + other.gameObject.name);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objects"))
        {
            Debug.Log("TriggerStay with: " + other.gameObject.name);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objects"))
        {
            Debug.Log("TriggerExit with: " + other.gameObject.name);
        }
    }
    //***
}
