using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, 1.5f);
    }

    public void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}
