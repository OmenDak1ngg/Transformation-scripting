using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleSpeed;

    private void FixedUpdate()
    {
        transform.localScale += _scaleSpeed;
    }
}
