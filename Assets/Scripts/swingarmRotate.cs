using System;
using UnityEngine;

public class swingarmRotate : MonoBehaviour
{
    public Transform pivot; //swingarm pivot point
    public Transform wheelfollow; //rear wheel follow point
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(pivot == null || wheelfollow == null)
        {
            Debug.LogError("Either pivot or wheelfollow is not assigned in swingarmRotate script");
            return;
        }

        transform.position = pivot.position;
        Vector3 direction = wheelfollow.position - pivot.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,angle);
    }
}
