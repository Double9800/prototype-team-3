using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public Transform cam;

    float Speed = 3f;
    private bool Rotazione = false;
   

    public float TimeR = 0.1f;
    public float Timerr;
    public float Velocità;

    private Vector3 Direzione;

    // Start is called before the first frame update
    void Start()
    {
        //Timerr = TimeR;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Movex = Input.GetAxis("Horizontal");
        float Movez = Input.GetAxis("Vertical");

        Direzione = new Vector3(Movex, 0, Movez);
        
        if(Direzione.magnitude >= 0.1)
        {
            //Timerr = TimeR;
            float targetAngle = Mathf.Atan2(Direzione.x, Direzione.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref Velocità, Timerr);
            transform.rotation = Quaternion.Euler(0f, Angle, 0f);
            Rotazione = true;
        }
       
    }

    private void FixedUpdate()
    {
        if (Rotazione == true)
        {
            //Timerr = 1f;
            rb.MovePosition(transform.position + (Direzione * Speed * Time.fixedDeltaTime));                  
        }
        
       
    }


}
