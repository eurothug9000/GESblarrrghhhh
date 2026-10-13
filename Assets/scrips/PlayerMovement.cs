using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public InputActionReference moveAction;
    public CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        // need to make player move forward based on the camera forward 
        // instead of always moving the player north when forward input is given

 
        Vector2 input = moveAction.action.ReadValue<Vector2>();

        var forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
      

        forward.y = 0;
        right.y = 0;


        forward.Normalize();
        right.Normalize();
        Vector3 direction = forward * input.y + right * input.x;


    
       // Debug.Log("input: " + input);
        //Vector3 direction = new Vector3(input.x,0, input.y);
        characterController.SimpleMove(speed * direction);
    }

}

