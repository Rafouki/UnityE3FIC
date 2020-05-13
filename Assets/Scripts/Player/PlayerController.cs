using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Translation & Rotation")]
    [Tooltip("La vitesse de transaltion en m.s-1")]
    [SerializeField] float m_TranslationSpeed;
    [SerializeField] float m_Speed;

    [Tooltip("La vitesse de rotation en °.s-1")]
    [SerializeField] float m_RotationSpeed;
    [SerializeField] float m_UprightRotKLerp;


    Rigidbody m_Rigidbody;
    

    private void Awake()
    {
        m_Rigidbody = GetComponentInChildren<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        m_Rigidbody.AddForce(movement * m_Speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        m_Rigidbody.AddForce(-movement/2 * m_Speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        


        /*
        //dynamique cinétique
        float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");


        //Mouvement
        Vector3 translationVect = vInput * transform.forward * m_TranslationSpeed * Time.deltaTime;
        m_Rigidbody.MovePosition(transform.position + translationVect);

        //qRotation*qOrientation = qNewOrientation
        float deltaAngle = hInput * m_RotationSpeed * Time.fixedDeltaTime;
        Quaternion qRot = Quaternion.AngleAxis(deltaAngle, transform.up);
        //Quaternion qUpright = Quaternion.FromToRotation(transform.up, Vector3.up);
        //Quaternion newOrientation = Quaternion.Lerp(transform.rotation, qUpright * transform.rotation, m_UprightRotKLerp * Time.fixedDeltaTime);
        Quaternion newOrientation = Quaternion.Lerp(transform.rotation, qRot * transform.rotation, m_UprightRotKLerp * Time.fixedDeltaTime);
        newOrientation = qRot * newOrientation;
        m_Rigidbody.MoveRotation(newOrientation);
        */
        
    }



}
