using UnityEngine;

public class swingarmBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform anchor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(anchor== null)
        {
            Debug.LogError("Anchor is missing in swingarmBehaviour script");
            return;
        }
        transform.position = anchor.position;
    }
}
