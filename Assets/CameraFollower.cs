using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _targetTrasform;

    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        Vector3 desirePositions = _targetTrasform.position + _offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desirePositions, _smoothSpeed);
        transform.position = smoothPosition;
    }
}
