using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int liczbacalkowita;
    float liczbaprzecinkowa;

    public float speed;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {

        //Wszystko co wpiszemy tutak wykonuje sie pod czas startu
        Debug.Log("Testowa informacja");
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float directionHorizontal = Input.GetAxis("Horizontal");
            rigidbody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Force);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float directionVertical = Input.GetAxis("Vertical");
            rigidbody.AddForce(directionVertical * Time.deltaTime * speed, 0, 0, ForceMode.Force);
        }


    }
}
