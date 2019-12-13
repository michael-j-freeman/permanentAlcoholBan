using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

      public static GameObject npcGroup = null;
      public float speed = 10.0f;
      private float translation;
      private float straffe;
      private bool inRange = false;

      // Use this for initialization
      void Start () {
          // turn off the cursor
          Cursor.lockState = CursorLockMode.Locked;

  	}
/*

    void OnCollisionEnter(Collision other)
    {
      Debug.Log( "collide (name) : " + other.collider.gameObject.name );
      //need to ensure it is npc
      inRange = true;

    }

    void OnCollisionExit(Collision other)
    {
      Debug.Log( "collide (name) : " + other.collider.gameObject.name );
      //nned to ensure it is npc
      inRange = false;

    }
*/

  	// Update is called once per frame
  	void Update () {
          // Input.GetAxis() is used to get the user's input
          // You can furthor set it on Unity. (Edit, Project Settings, Input)
          if(npcGroup == null){
            //free movement when not in a group
            translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(straffe, 0, translation);
          }else{
            //movment locked to group
            transform.position = new Vector3(npcGroup.transform.position.x - 1f,npcGroup.transform.position.y, npcGroup.transform.position.z - 1f);
          }

          if (Input.GetKeyDown("escape")) {
              // turn on the cursorS
              Cursor.lockState = CursorLockMode.None;
          }

          if(Input.GetKeyDown(KeyCode.R)){
            npcGroup = null;
          }

      }
}
