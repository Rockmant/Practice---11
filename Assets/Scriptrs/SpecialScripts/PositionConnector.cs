using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionConnector : MonoBehaviour
{
    [SerializeField] private Transform connectToPosition;
    private Transform selfPos;
    private void Start()
    {
        selfPos = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        selfPos.position = connectToPosition.position;
    }
}
