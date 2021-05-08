using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStaff : MonoBehaviour
{
    // [SerializeField] Camera TPCamera;
    // [SerializeField] float range = 100f;
    [SerializeField] Transform firePoint;
    int damage = 1;

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

        Ray ray = new Ray(firePoint.position, firePoint.forward);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, 100))
        {
            var health = hitInfo.collider.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }
    }
}
