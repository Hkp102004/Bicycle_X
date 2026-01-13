using UnityEngine;

public class front_anchor_pos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform front_anchor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (front_anchor == null)
        {
            Debug.LogError("Front anchor is missing!");
        }

        Vector3 pos = transform.position;
        pos.x = front_anchor.position.x;
        pos.y = front_anchor.position.y;
        transform.position = pos;
    }
}
