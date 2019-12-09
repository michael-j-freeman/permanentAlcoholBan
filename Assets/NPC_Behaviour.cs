using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Behaviour : MonoBehaviour
{
  public Transform[] points;
  private int destPoint = 0;
  private UnityEngine.AI.NavMeshAgent agent;
  public TextMesh g;
  private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        g = GetComponent<TextMesh>();
        agent.autoBraking = false;
        GotoNextPoint();
    }


    void GotoNextPoint() {
          // Returns if no points have been set up
          if (points.Length == 0){
              return;
            }
          // Set the agent to go to the currently selected destination.
          agent.destination = points[destPoint].position;
          // Choose the next point in the array as the destination,
          // cycling to the start if necessary.
          destPoint = (destPoint + 1) % points.Length;
      }

      void OnTriggerEnter(Collider other)
    {
      Debug.Log("DDDD");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");

            g.text = "Hello";
            agent.Stop();
            //here we stop and talk
        }

      }



      void OnTriggerExit(Collider other)
     {
         agent.Resume();

         g.text = "";
     }

    // Update is called once per frame
    void Update()
    {
      //rb.velocity = transform.right * 10;
      if (!agent.pathPending && agent.remainingDistance < 0.5f){
          GotoNextPoint();
        }
    }
}
