using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray(
            transform.position, 
            transform.position
        );
    }

    // Update is called once per frame
    void Update()
    {
       ray = new Ray(
            transform.position, 
            transform.position
        );
        Debug.DrawRay(ray.origin, ray.direction * 30, Color.red);
    }
}
