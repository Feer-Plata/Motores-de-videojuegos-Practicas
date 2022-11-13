using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f) + offset;
        target.position = Vector3.Slerp(target.position, newPos, speed * Time.deltaTime);
    }
}
