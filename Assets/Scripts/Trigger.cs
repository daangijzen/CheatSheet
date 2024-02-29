using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] private UnityEvent doSomething;

    // This is triggered when a 3D object with collision and a rigidBody.
    // The standard unity function "OnTriggerEnter" can only be used on an 3D-object with a 3D-collider with "Is Trigger" set to true.
    private void OnTriggerEnter()
    {
        // Here we "Invoke" or "Start" the unity event. Every time something enters the trigger.
        doSomething.Invoke();

        print("Entered trigger");
    }

    // As the name suggests, this function triggers when a rigidBody stays inside of the trigger.
    // This happens every frame that something is inside of the trigger
    private void OnTriggerStay()
    {
        print("Stay in trigger");
    }

    // And this function triggers every time a object leaves a trigger.
    private void OnTriggerExit()
    {
        print("Left trigger");
    }


    // All these functions are part of the UnityEngine namespace. These are the core features that unity provides you in the code.
}
