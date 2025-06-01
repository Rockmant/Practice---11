using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    public Vector3 offset;
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }
    private Vector3 RotateXZ(Vector3 vector, float angle)
    {
        Vector3 pos = new Vector3(
            vector.x * Mathf.Cos(angle) - vector.z * Mathf.Sin(angle),
            vector.y,
            vector.x * Mathf.Sin(angle) + vector.z * Mathf.Cos(angle));

        return pos;
    }
    private void RotationInput()
    {
        if (Input.GetKey(KeyCode.Q))
        {
           
            offset = RotateXZ(offset, 0.1f);
            transform.LookAt(playerTransform.position);
        }
        if (Input.GetKey(KeyCode.E))
        {
            offset = RotateXZ(offset, -0.1f);
            transform.LookAt(playerTransform.position); // Камера что-то дергается при нажатиях "qe", не понимаю почему?
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RotationInput();
        transform.position = playerTransform.position + offset;
        //transform.LookAt(playerTransform.position); //а вот так все красиво но это лишняя нагрузка
    }
}
