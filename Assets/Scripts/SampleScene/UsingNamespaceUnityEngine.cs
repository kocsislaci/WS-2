// Base class for all objects Unity can reference.
public class MyObject : UnityEngine.Object
{
    // getHash
        
    // equals
        
    // getName
    // setName
        
        
    // instantiate
    // Clones the object original and returns to clone
    
    // find functions
    // find
    
    // destroy
    // gameObject, component or asset; depends on what we call on
        
    // ...
}

// Base class for everything attached to a GameObject
public class MyComponent : UnityEngine.Component
{
    // The Transform attached to this GameObject. The only mandatory component
    // transform
        
    // gameObject this component is attached to
}

// Position, rotation and scale of an object.
public class MyTransform : UnityEngine.Transform
{
    // position
        
    // local position
        
    // euler Angles
        
    // local euler angles

    // rotation stored in Quaternion
        
    // local rotation stored in Quaternion
        
    // parent
    // setParent
        
    // translate
        
    // rotate
        
    // rotateAround
        
    // lookAt
        
    // etc.
}
    
// Base class for all entities in Unity Scenes
// but is sealed so we can's derive from it
public class MyGameObject // : UnityEngine.GameObject
{
    // name
        
    // tag
        
    // layer
        
    // isStatic

    // isActive
        
    // components
    // getComponent
    // addComponent
        
    // scene, the gameObject is part of
}
    
// A class you can derive from if you want to create objects that don't need to be attached to game objects.
public class MyScriptableObject : UnityEngine.ScriptableObject
{
    // good to use if we need shared, rarely changing data
}