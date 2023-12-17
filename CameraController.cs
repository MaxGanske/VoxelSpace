
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBorderThickness = 10f;

    public Vector2 panLimit;

    public float scrollSpeed = 20f;
    public float minY = 20f;
    public float maxY = 60f;


    // Update is called once per frame
    void Update()
    {
        
    

        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;
    }
}
