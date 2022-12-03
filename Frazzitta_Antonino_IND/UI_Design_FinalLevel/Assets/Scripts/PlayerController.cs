using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera playerFollower;
    public NavMeshAgent agent;
    RaycastHit hit;

    Animator myAnim;
    float dist;
    Quaternion newRotation;
    float rotSpeed = 5f;

    void Start()
    {

        myAnim = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerFollower.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                myAnim.SetBool("isRunning", true);

                agent.SetDestination(hit.point);

        
                Vector3 relativePos = hit.point - transform.position;
                newRotation = Quaternion.LookRotation(relativePos, Vector3.up);
                newRotation.x = 0.0f;
                newRotation.z = 0.0f;

                

            }
        }
        dist = Vector3.Distance(hit.point, transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotSpeed * Time.deltaTime);
        if (dist < 1f)
        {
            myAnim.SetBool("isRunning", false);
        }
    }
}
