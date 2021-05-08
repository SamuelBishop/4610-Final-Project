using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStaff : MonoBehaviour
{
    // [SerializeField] Camera TPCamera;
    // [SerializeField] float range = 100f;
    [SerializeField] Transform firePoint;
    int damage = 1;

    // For projectile
    [SerializeField] GameObject fireball;
    public float speed = 10f;


    [SerializeField] private ParticleSystem staffParticle;

    // Remove unnecessary stuff later
    void Start()
    {
        staffParticle.Play();
    }

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
        GameObject instFireball = Instantiate(fireball, transform.position, Quaternion.identity) as GameObject;
        Rigidbody instFireballRigidbody = instFireball.GetComponent<Rigidbody>();
        // instFireballRigidbody.AddForce(Vector3.forward * speed);

        instFireballRigidbody.AddRelativeForce(new Vector3(firePoint.forward.x * 30, firePoint.forward.y * 30, firePoint.forward.z * 30) * speed);

        // 

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
