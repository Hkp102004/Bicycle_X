using UnityEngine;
using UnityEngine.Rendering;

public class suspensionBehaviour : MonoBehaviour
{
    public Transform topAnchor; //top anchor connected to the body 
    public Transform bottomAnchor; //bottom anchor connected to the wheel

    public float minLength = 0.2f;
    public float maxLength = 0.6f;
    void Start()
    {
        if(topAnchor == null || bottomAnchor == null)
        {
            Debug.LogError("Top or bottom anchor is missing for yellow suspension");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 direction = (bottomAnchor.position - topAnchor.position).normalized;
        float distance = Vector3.Distance(topAnchor.position, bottomAnchor.position);
        float Length = Mathf.Clamp(distance, minLength, maxLength);
    }
}
