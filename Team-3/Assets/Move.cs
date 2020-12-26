using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public Transform cam;

    float Speed = 3f;

    public float TimeR = 0.1f;
    public float Velocità;

    private Vector3 Direzione;

    // Start is called before the first frame update
    void Start()
    {
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
            float targetAngle = Mathf.Atan2(Direzione.x, Direzione.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref Velocità, TimeR);
            transform.rotation = Quaternion.Euler(0f, Angle, 0f);
        }
       
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + (Direzione * Speed* Time.fixedDeltaTime));
    }


}
