using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionReference moveAction;
    void Start()
    {

    }
    void Update()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        Debug.Log("input: " + input);
    }

}

