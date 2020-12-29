using UnityEngine;

public class PlayerProjectileShooter : MonoBehaviour
{
    public GameObject projectile;
    public Transform firePoint;

    [SerializeField] float speed = 1000f;

    public Camera playerCamera;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootProjectile();
        }
    }

    private void ShootProjectile()
    {
        GameObject projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        Rigidbody projectileRigidBody = projectileObj.GetComponent<Rigidbody>();
        projectileRigidBody.velocity = playerCamera.transform.forward * speed * Time.deltaTime;
        // TODO: Remove projectiles after a while that will not hit anything
    }
}
