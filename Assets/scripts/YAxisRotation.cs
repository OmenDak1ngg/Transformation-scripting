using UnityEngine;

public class YAxisRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * _rotationSpeed);        
    }
}
