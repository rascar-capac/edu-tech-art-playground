using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Rigidbody projectile;
    [SerializeField] private CannonData data;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > data.SpawnRate)
        {
            Rigidbody spawnedProjectile = Instantiate(projectile, transform.position, transform.rotation);
            spawnedProjectile.AddForce(transform.forward * data.Power, ForceMode.Impulse);
            timer = 0;
        }
    }
}