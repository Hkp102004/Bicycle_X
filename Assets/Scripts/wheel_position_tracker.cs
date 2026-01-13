using UnityEngine;

public class wheel_position_tracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform wheelPosition; //tracks the position of the wheel
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(wheelPosition == null)
        {
            Debug.LogError("Wheel position is missing from position tracker script.");
        }

        transform.position = wheelPosition.position;
    }
}
