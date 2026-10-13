using UnityEngine;
using UnityEngine.InputSystem;

public class playerInteractor : MonoBehaviour
{
    //vada vada
    public float interactDistance = 3;
    public InputActionReference interactAction;

    private void OnEnable()
    {
        interactAction.action.performed += OnInteractPerformed;
    }
    private void Update()
    {
        Transform camP = Camera.main.transform;
        RaycastHit raycastHitInfo;
        bool didRaycast = Physics.Raycast(camP.position, camP.forward, out raycastHitInfo, interactDistance);
            //hysics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,interactDistance);
            //(Camera.main.transform.position, Camera.main.transform.forward * interactDistance);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * interactDistance, Color.red);
        if (didRaycast)
        {
            string hitObjectname = raycastHitInfo.collider.gameObject.name;
            Debug.Log("raycast hit" + hitObjectname);
            
        }


    }

    private void OnInteractPerformed(InputAction.CallbackContext callbackContext) 
    {
        Debug.Log("I button pressed");
    
    }
}
