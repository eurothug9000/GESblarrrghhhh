using UnityEngine;
using UnityEngine.InputSystem;

public class playerInteractor : MonoBehaviour
{
    public float interactDistance = 3;
    public InputActionReference interactAction;

    private void OnEnable()
    {
        interactAction.action.performed += OnInteractPerformed;
    }
    private void Update()
    {

        bool didRaycast = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, interactDistance);
            //(Camera.main.transform.position, Camera.main.transform.forward * interactDistance);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * interactDistance, Color.red);
        if (didRaycast)
        {
            Debug.Log("raycast hit something");
        }


    }

    private void OnInteractPerformed(InputAction.CallbackContext callbackContext) 
    {
        Debug.Log("I button pressed");
    
    }
}
