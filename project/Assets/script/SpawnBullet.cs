using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
   public GameObject bulletPrefab;
   public float bulletSpeed;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            Fire();
        }
        
    }

    private void Fire() {

        GameObject bullet =  Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        Destroy(bullet, 5f);

    }
}
