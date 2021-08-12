using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
   
    NavMeshAgent nav;
    Animator anim;
    NavMeshModifier modifier;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim=GetComponent<Animator>();

        modifier = GetComponent<NavMeshModifier>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                anim.SetBool("Walk", true);
                nav.SetDestination(hit.point);
                if (Input.mousePosition == this.transform.position)
                {
                    anim.SetBool("Walk", false);

                }
            }
        }
        //else if (Input.GetMouseButtonDown(1))
        {
            //if (modifier.overrideArea == true)
            {
                //modifier.
            }
        }
        
    }
}
