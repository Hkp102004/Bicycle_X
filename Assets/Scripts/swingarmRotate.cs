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
    }
}
