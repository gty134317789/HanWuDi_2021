using UnityEngine;
using System.Collections;
public class CameraSwitch: MonoBehaviour
{
    private GameObject camera_0;
    private GameObject camera_1;
    void Start()
    {
        camera_0 = GameObject.Find("青铜爵摄像头");
        camera_1 = GameObject.Find("青铜剑摄像头");
        camera_1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            camera_0.SetActive(false);
            camera_1.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {

            camera_0.SetActive(true);
            camera_1.SetActive(false);
        }

    }
}