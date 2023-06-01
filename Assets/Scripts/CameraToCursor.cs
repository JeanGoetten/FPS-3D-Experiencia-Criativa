using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToCursor : MonoBehaviour
{
    public float speed; 

    private void Update() {
        Plane playerPlane = new Plane (Vector3.up, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float hitdist = 0.0f;
        if (playerPlane.Raycast(ray, out hitdist)){
            Vector3 targetPoint = ray.GetPoint(hitdist);

            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
        
    }

    // private void LookAtMouse(){

    //     Vector3 mousePos = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    //     transform.right = (Vector3)(mousePos - new Vector3(transform.position.x, transform.position.y, transform.position.z)); 
    // }
}
