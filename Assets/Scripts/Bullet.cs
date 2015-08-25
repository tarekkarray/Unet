using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float velocity = 2f;
    public float timeToLive = 2f;
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Vector3.forward * velocity, Space.Self);
	}

    void OnCollisionEnter(Collision col)
    {
        gameObject.SetActive(false);
    }
    void OnEnable()
    {
        StartCoroutine(WaitBeforeDisable());
    }
    private IEnumerator WaitBeforeDisable()
    {
        yield return new WaitForSeconds(timeToLive);
        gameObject.SetActive(false);
    }
}
