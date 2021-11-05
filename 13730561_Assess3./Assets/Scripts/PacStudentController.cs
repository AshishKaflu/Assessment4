using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float Speed = 04f;
    public Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {


        //float horizontalmovement = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed;
        //float verticalmovement = Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed;

        if (Input.GetKeyDown(KeyCode.S))
        {
            animatorController.SetTrigger("DownParam");
        }

        if(Input.GetKeyDown(KeyCode.W)) {
            animatorController.SetTrigger("UpParam");
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            animatorController.SetTrigger("LeftParam");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animatorController.SetTrigger("RightParam");
        }

        float horizontalmovement = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed;
        float verticalmovement = Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed;
        transform.Translate(horizontalmovement, verticalmovement, 0);

    }


    

}
