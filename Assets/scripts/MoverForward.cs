using UnityEngine;

public class MoverForward : MonoBehaviour
{
    private float _moveSpeed = 10f;

    private void Update()
    {
        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime);
    }
}
