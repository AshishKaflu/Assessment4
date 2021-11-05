using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float Speed = 04f;
    public Animator animatorController;
    public ParticleSystem Dust;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            animatorController.SetTrigger("DownParam");
            CreateDust();
        }

        if(Input.GetKeyDown(KeyCode.W)) {
            animatorController.SetTrigger("UpParam");
            CreateDust();
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            animatorController.SetTrigger("LeftParam");
            CreateDust();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animatorController.SetTrigger("RightParam");
            CreateDust();
        }

        float horizontalmovement = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed;
        float verticalmovement = Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed;
        transform.Translate(horizontalmovement, verticalmovement, 0);

    }

    void CreateDust()
    {
        Dust.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Pellets"))
        {
            Destroy(other.gameObject);
        }
    }


}
