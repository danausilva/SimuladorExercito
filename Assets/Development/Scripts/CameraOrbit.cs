using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraOrbit : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private Transform target;
    [SerializeField, Range(1, 50)]
    private float distance = 10.0f;
    [SerializeField, Range(1, 500)]
    private float xSpeed = 250.0f;
    [SerializeField, Range(1, 500)]
    private float ySpeed = 120.0f;
    private float yMinLimit = -20;
    private float yMaxLimit = 80;
    private float x = 0.0f;
    private float y = 0.0f;

    void LateUpdate()
    {
        if (target && Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
            y = ClampAngle(y, yMinLimit, yMaxLimit);

            var rotation = Quaternion.Euler(y, x, 0);
            var position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }

    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
        {
            angle += 360;
        }

        if (angle > 360)
        {
            angle -= 360;
        }

        return Mathf.Clamp(angle, min, max);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}