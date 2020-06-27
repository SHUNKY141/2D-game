using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _cam;
    public Transform Target;
    public float FollowSpeed = 1;

    private void Awake()
    {
        _cam = Camera.main.transform;
    }

    private void Update()
    {
        Follow();
    }

    private void Follow()
    {
        var _temp = new Vector3(
            Mathf.Lerp(_cam.position.x, Target.position.x, Time.deltaTime * FollowSpeed),
            Mathf.Lerp(_cam.position.y, Target.position.y + 2, Time.deltaTime * FollowSpeed),
            _cam.position.z);
        _cam.position = _temp;
    }
}
