using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    private float _moveSpeed = 0.5f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * _moveSpeed);
    }
}
