using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStaff : MonoBehaviour
{
    // [SerializeField] Camera TPCamera;
    // [SerializeField] float range = 100f;
    [SerializeField] Transform firePoint;

    // Remove unnecessary stuff later
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootFireball();
        }
    }

    private void ShootFireball()
    {
        Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.red, 2f); 
        Debug.Log("Hit object " + firePoint.transform.name);





        // // Might not use
        // // RaycastHit hit;
        // // Physics.Raycast(TPCamera.transform.position, TPCamera.transform.forward, out hit, range);

        // RaycastHit cameraHit;
        // Ray cameraAim = TPCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2));
        // Physics.Raycast(cameraAim, out cameraHit, 100f);
        // Debug.DrawLine(cameraAim.origin, cameraHit.point, Color.green);
        // Vector3 cameraHitPoint = cameraHit.point;
        // float cameraDistance = cameraHit.distance;


        // Debug.Log("Hit object " + cameraHit.transform.name);
        // Debug.DrawRay(transform.position, transform.forward, Color.green); 
        
        // // Debug.DrawRay(transform.position + new Vector3 (0f, 1.8f, 0f), cameraHitPoint-transform.position - new Vector3 (0f, 1.8f, 0f), Color.red);
    }
}
