using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //mengambil komponen pada hierarki player gameobject
   public CharacterController controller;
    //mengatur kecepatan berjalan pada komponen gameobject
    public float speed; 
    
    void Start()
    {
         
    }

    void Update()
    {   
        //mengambil inputan
        float x = Input.GetAxis("Horizontal"); 
        float y = Input.GetAxis("Vertical");
        
        Vector3 move = transform.forward * y + transform.right * x;
        controller.SimpleMove(move*speed);
    }
}
