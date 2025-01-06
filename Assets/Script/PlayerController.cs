using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform minXPlayerPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        //.................................................INSTRUKCJA_K0D0WANIA_W_C#............................................................//
        // 1) JESLI wciskamy przycisk A to jest to w 'if'

        // 2) JESLI pozycja gracza na osi X jest wi�ksza od -3.55f to wykonaj to co wewnontrz klamry ykonuje si� to je�eli warunek jest spe�niony

        // 3) 'transform.Translate' przesuwa obiekt o Vector

        // 4) 'Vector3' uzywa sie do gier 3D, a 'Vector'  uzywa sie do gier 2D

        // 5) JESLI -> 'else' warunek nie jest spe�niony to w klamrach wykomuje sie te rzeczy (*)

        // 6) przyk�ad:  if (Input.GetKey(KeyCode.E)) <-  WARUNEK jest w nawiasie obok 'if'.      <  'if' -> Warunek    >

        // 7)

        //......................................................................................................................................//


        if (Input.GetKey(KeyCode.A)) // (1)
        {
            if (transform.position.x > -3.55f) // (2)

               //if (transform.position.x > minXPlayerPos.position.x) -> Ten fragment u�ywa sie, gdy dodaje si� ogranicznik w formie EmptyObject
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed); // (3) i (4)
            }
            else if (transform.position.x < 3.55f) // (5)
            {
                //(*)


            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 3.55f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);

            }

        }
    }
       
    

       


        
}
