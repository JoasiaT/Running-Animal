using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        //.................................................INSTRUKCJA_K0D0WANIA_W_C#............................................................//
        // 1) Jezeli wciskamy przycisk A to jest to w 'if'

        // 2) Jezeli pozycja gracza na osi X jest wiêksza od -3.55f to wykonaj to co wewnontrz klamry ykonuje siê to je¿eli warunek jest spe³niony

        // 3) 'transform.Translate' przesuwa obiekt o Vector

        // 4) 'Vector3' uzywa sie do gier 3D, a 'Vector'  uzywa sie do gier 2D

        // 5) Jezeli warunek nie jest spe³niony dla 'else' to w klamrach wykomuje sie te rzeczy




        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -3.55f) 
            {  
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed); 
            }
            else 
            {
     

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

    }
       
    

       


        
}
