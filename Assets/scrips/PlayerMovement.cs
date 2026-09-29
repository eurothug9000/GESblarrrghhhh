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
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        Debug.Log("input: " + input);
        Vector3 direction = new Vector3(input.x,0, input.y);
        characterController.SimpleMove(speed * direction);
    }

}

