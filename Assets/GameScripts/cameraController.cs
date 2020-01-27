using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    /*public float minimumX = -60.0f;
    public float maximumX = 60.0f;
    public float minimumY = -360.0f;
    public float maximumY = 360.0f;

    public float sensitivityX = 15.0f;
    public float sensitivityY = 15.0f;
    public Camera cam;

    float rotationY = 0.0f;
    float rotationX = 0.0f;
    */

     Vector2 mouseLook;
     Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;

    void Start ()
    {
        character = this.transform.parent.gameObject;
	}
	

	void Update ()
    {
        /*
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;

        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);*/

        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
