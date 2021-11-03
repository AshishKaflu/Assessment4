using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman_Movement : MonoBehaviour
{

    public GameObject[] nodes;
    int inital = 0;
    public float speed;
    float nodesradius = (float)0.1;
  


    public Animator animatorController;





    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(nodes[inital].transform.position, transform.position) < nodesradius)
        {
            inital++;
            if(inital >= nodes.Length)
            {
                inital = 0;
            }
            Debug.Log(inital);
        }
        transform.position = Vector2.MoveTowards(transform.position, nodes[inital].transform.position, Time.deltaTime * speed);

        
        if (inital >= 3)
        {
            animatorController.SetTrigger("DownParam");
        }

        if (inital >= 0)
        {
            animatorController.SetTrigger("LeftParam");
        }

        if (inital >= 2)
        {
            animatorController.SetTrigger("RightParam");
        }

        if (inital >= 1)
        {
            animatorController.SetTrigger("UpParam");
        } 
    }

 
}
