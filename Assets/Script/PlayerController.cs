using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //INVERT CONTROLLER ! D to jest w Lewo, 
    void Update()
    { 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

       // if (Input.GetKey(KeyCode.))
       // {

        //}

    }
       
    

       


        
}
