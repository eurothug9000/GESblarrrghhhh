using UnityEngine;
using UnityEngine.InputSystem;

public class playerInteractor : MonoBehaviour
{
    public InputActionReference interactAction;

    private void OnEnable()
    {
        interactAction.action.performed += OnInteractPerformed;
    }
    private void OnInteractPerformed(InputAction.CallbackContext callbackContext) 
    {
        Debug.Log("I button pressed");
    
    }
}
