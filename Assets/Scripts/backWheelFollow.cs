using UnityEngine;

public class backWheelFollow : MonoBehaviour
{
    public Transform backwheel; //this will keep track of the back wheel position
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(backwheel == null)
        {
            Debug.LogError("Back wheel is not found in backWheelFolow script");
            return;
        }

        transform.position = backwheel.position;
    }
}
