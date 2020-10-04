using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed;
    public float maxTravelDistanceZ = 100f;

    public GameObject speed1;
    public GameObject speed2;
    public GameObject speed3;
    public GameObject speed4;
    public GameObject speed5;
    public GameObject speedBack;

    Rigidbody rb;
    public int CurrentSpeed; //  now also for fuel
    bool isGrounded;
    
    public float rotationSpeed = 100.0F;


    // Use this for initialization
    void Start()
    {
        CurrentSpeed = 0;
        rb = GetComponent<Rigidbody>();
    }

    void GroundCheck()
    {
        RaycastHit hit;
        float distance = 3f;
        Vector3 dir = new Vector3(0, -2);
        Debug.DrawRay(transform.position, dir, Color.green);
        if (Physics.Raycast(transform.position, dir, out hit, distance))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        GroundCheck();

        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0 && isGrounded == true)
        {
            if (CurrentSpeed < 5)
            {
                CurrentSpeed = CurrentSpeed + 1;
                ChangeSpeedDisplay(CurrentSpeed);
            }
        }

        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0 && isGrounded == true)
        {
            if (CurrentSpeed > -5 && CurrentSpeed >= 0)
            {
                CurrentSpeed = CurrentSpeed - 1;
                ChangeSpeedDisplay(CurrentSpeed);
            }
        }

        if (isGrounded == false)
        {
            CurrentSpeed = 0;
            ChangeSpeedDisplay(CurrentSpeed);
        }

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, rotation);

        rb.AddForce(transform.up * CurrentSpeed * baseSpeed * Time.deltaTime);

        /*
        if (transform.position.z <= maxTravelDistanceZ)
        {
            transform.position += transform.up * CurrentSpeed * baseSpeed * Time.deltaTime;
        }
        else
        {
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, maxTravelDistanceZ - 1f);
            transform.position = newPosition;
        }
        */
        
        
    }

    private void ChangeSpeedDisplay(int speed)
    {
        if(speed == 0)
        {
            speed1.SetActive(false);
            speed2.SetActive(false);
            speed3.SetActive(false);
            speed4.SetActive(false);
            speed5.SetActive(false);
            speedBack.SetActive(false);
        }
        if (speed == 1)
        {
            speed1.SetActive(true);
            speed2.SetActive(false);
            speed3.SetActive(false);
            speed4.SetActive(false);
            speed5.SetActive(false);
            speedBack.SetActive(false);
        }
        if (speed == 2)
        {
            speed1.SetActive(false);
            speed2.SetActive(true);
            speed3.SetActive(false);
            speed4.SetActive(false);
            speed5.SetActive(false);
            speedBack.SetActive(false);
        }
        if (speed == 3)
        {
            speed1.SetActive(false);
            speed2.SetActive(false);
            speed3.SetActive(true);
            speed4.SetActive(false);
            speed5.SetActive(false);
            speedBack.SetActive(false);
        }
        if (speed == 4)
        {
            speed1.SetActive(false);
            speed2.SetActive(false);
            speed3.SetActive(false);
            speed4.SetActive(true);
            speed5.SetActive(false);
            speedBack.SetActive(false);
        }
        if (speed == 5)
        {
            speed1.SetActive(false);
            speed2.SetActive(false);
            speed3.SetActive(false);
            speed4.SetActive(false);
            speed5.SetActive(true);
            speedBack.SetActive(false);
        }
        if (speed == -1)
        {
            speed1.SetActive(false);
            speed2.SetActive(false);
            speed3.SetActive(false);
            speed4.SetActive(false);
            speed5.SetActive(false);
            speedBack.SetActive(true);
        }
    }
}
