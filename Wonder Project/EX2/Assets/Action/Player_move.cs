using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_move : MonoBehaviour
{
    public Rigidbody rd;
    Vector3 pos;
    //public GameObject panel;
    public float speed;
    //public GameObject stage2;
    public GameObject goulTexst;

    // Use this for initialization
    void Start()
    {
         pos = transform. position;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Down();

        DebugMode();
        //SpeedMayer();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            transform.position = pos;
            rd.velocity = Vector3.zero;
        }

        if (other.gameObject.tag == "wrap")
        {
            pos = new Vector3(0, 1, 140);
            rd.velocity = Vector3.zero;
            //SceneManager.LoadScene("stage2");
            //pos = stage2.transform.position;
        }

        if(other.gameObject.tag=="goul")
        {
            goulTexst.GetComponent<Text>().enabled = true;
        }

    }



    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rd.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rd.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rd.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rd.AddForce(-speed, 0, 0);
        }
        //Debug.Log(rd.velocity.magnitude);
    }

    private void Down()
    {
        if (transform.position.y < -10)
        {
            transform.position = pos;
            rd.velocity = Vector3.zero;
        }
    }

    private void DebugMode()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(0, 1, 140);
        }
    }

    void SpeedMayer()
    {
        if(rd.velocity.magnitude>=30)
        {
            rd.AddForce(0, 0, 0);
        }
    }

}
