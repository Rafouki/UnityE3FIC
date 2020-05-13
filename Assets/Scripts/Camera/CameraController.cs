using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 offsetCamera;

    [Range(0.01f, 1.0f)]
    [SerializeField] float smooth;
    void Start()
    {
        offsetCamera = transform.position - target.position;
    }

    void Update()
    {


        //transform.Rotate(0, transform.rotation.y, 0);

        
        Vector3 cameraPosition = target.position + offsetCamera;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, cameraPosition, smooth);
        //transform.position = smoothPosition;
        //transform.LookAt(target);
        
        float Hcamera = Input.GetAxis("R_Horizontal");
        Debug.Log("Value axis : " + Hcamera);
        //transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z);
        //transform.RotateAround(target.position,Vector3.up, Hcamera*30*Time.deltaTime );
        Debug.Log(target.position.ToString());
        
        //transform.LookAt(target);


    }
}
