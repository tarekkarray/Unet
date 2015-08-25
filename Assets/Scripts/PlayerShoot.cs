using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public Transform guntip;
    public float fireRate = 0.5f;
    private float lastFireTime = 0f;
    private BulletPool bulletpool;
	// Use this for initialization
	void Start () {
        bulletpool = GetComponent<BulletPool>();
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetMouseButtonDown(0) && (lastFireTime+fireRate)<Time.time)
        {
            bulletpool.FireBullet();
            lastFireTime = Time.time;
        }
	}
}
