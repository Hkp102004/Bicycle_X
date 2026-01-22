using UnityEngine;

public class swingarm : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform swingarmAnchor;
    public Transform swingarmPiviot;
    public Transform backWheel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(swingarmAnchor==null || swingarmPiviot== null || backWheel == null)
        {
            Debug.LogError("Either swingarm, or swingarmAnchor or backwheel is missing from swingarm script");
            return;
        }

        Vector3 direction = backWheel.position - swingarmAnchor.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        swingarmPiviot.rotation = Quaternion.Euler(0,0,angle);
    }
}
