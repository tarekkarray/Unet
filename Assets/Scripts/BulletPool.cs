using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BulletPool : MonoBehaviour {

    protected BulletPool(){}
    public GameObject bulletPrefab;
    public Transform gunTip;
    private List<GameObject> bulletList;
    

    void Start()
    {
        bulletList = new List<GameObject>();
    }
    public void FireBullet()
    {
        GameObject bullet = bulletList.FirstOrDefault(bulletX => !bulletX.activeInHierarchy);
        if(bullet == null)
        {
            bullet = (GameObject)Instantiate(bulletPrefab, gunTip.position, gunTip.rotation);
            bulletList.Add(bullet);
        }
        bullet.transform.position = gunTip.position;
        bullet.transform.rotation = gunTip.rotation;
        bullet.SetActive(true);
    }
	
}
