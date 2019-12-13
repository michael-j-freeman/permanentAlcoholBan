using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cop_Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(CharacterController.npcGroup != null){
          //runn in cicurles
          //move up and down (Do nothing for now)
        }else{
          //chase him
          transform.position = Vector3.MoveTowards(transform.position, target.position, 0.1f);
        }
    }
}
