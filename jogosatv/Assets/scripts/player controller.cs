using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputAsset;
    private InputAction _moveAction;
    private Rigidbody _rb;
    public float speed = 10f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _moveAction = inputAsset.FindAction("Move");
        _moveAction.Enable();
    }

    void FixedUpdate()
    {
        Vector2 move = _moveAction.ReadValue<Vector2>();
        _rb.AddForce(new Vector3(move.x, 0, move.y) * speed);
    }
}
