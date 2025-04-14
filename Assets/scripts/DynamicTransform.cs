using UnityEngine;

public class DynamicTransform : MonoBehaviour
{
    private float _moveSpeed = 0.5f;
    private float _rotationSpeed = 10f;
    private float _scaleSpeed = 0.01f;
    private Vector3 _direction = Vector3.right;
    private Vector3 _normalizedVector = new Vector3(1, 1, 1);

    private void FixedUpdate()
    {
        transform.Translate(_direction * _moveSpeed);

        transform.Rotate(Vector3.up * _rotationSpeed);

        transform.localScale += _normalizedVector * _scaleSpeed;
    }
}
