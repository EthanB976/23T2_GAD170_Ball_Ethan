using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Move out object based on input from the player

        // transform.position
        //Vector3 moveDirection = Vector3.forward * Time.deltaTime;
        //transform.position = transform.position + moveDirection;

        // when player press key move character

        //if 'press D' move +X
        //if (Input.GetKeyDown(KeyCode.D)) 
        //{
        //    transform.position += Vector3.right;
        //}

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += Vector3.left;
        //}

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += Vector3.forward;
        //}

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += Vector3.back;
        //}


        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime * 15;
        
    }
}
 