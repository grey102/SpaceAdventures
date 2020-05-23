using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    void Update() {
         
      if (Input.GetKey("up"))
          {
             transform.position += new Vector3(0f, 0.1f, 0f); 
          }

      
      if (Input.GetKey("down"))
         {
             transform.position -= new Vector3(0f, 0.1f, 0f);
         }

    }
}