using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    bool canJump;


    void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }


    void Awake()
    {
        Debug.Log("Awake");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-1000f * Time.deltaTime, 0, 0);
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
        }

        if(Input.GetKey("right"))
        {
            gameObject.transform.Translate(1000f * Time.deltaTime, 0, 0);
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
        }

        if (Input.GetKey("up"))
        {
            //canJump = true;
            gameObject.transform.Translate(0, 5000f * Time.deltaTime, 0);
            
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,100f));
        }

        //ManageJump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            canJump = true;

        }
    }


}
