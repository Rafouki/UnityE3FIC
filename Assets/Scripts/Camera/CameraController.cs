using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 offsetCamera;

    [Range(0.01f, 1.0f)]
    [SerializeField] float smooth;
    public float MinDist, CurrentDist, MaxDist, TranslateSpeed, AngleH, AngleV;
    void Start()
    {
        //offsetCamera = transform.position - target.position;
    }

    void Update()
    {

        //transform.position = Vector3.Lerp(transform.position, target.position, 0.1f);
        //transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        /*
        Vector3 cameraPosition = target.position + offsetCamera;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, cameraPosition, smooth);
        transform.position = smoothPosition;
        transform.position = cameraPosition;
        transform.LookAt(target);
        */
        //Vector3 cameraPosition = target.position + offsetCamera;
        //float Hcamera = Input.GetAxis("R_Horizontal");
        //Debug.Log("Value axis : " + Hcamera);
        //transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z);

        //transform.RotateAround(target.position,Vector3.up, Hcamera*30*Time.deltaTime );
        //transform.LookAt(target);

    }
}
