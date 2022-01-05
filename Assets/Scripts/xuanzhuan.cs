using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xuanzhuan : MonoBehaviour
{
    [Header("操作对象")]
    /// <summary>
    /// 操作对象
    /// </summary>
    public Transform m_target;
    void Start()
    {
        isDown1 = false;
        isDown2 = false;
    }
    /// <summary>
    /// 右键是否按下 
    /// </summary>
    private bool isDown1;

    /// <summary>
    /// 中键是否按下
    /// </summary>
    private bool isDown2;
    void Update()
    {
        // 按下了鼠标中键
        if (Input.GetMouseButtonDown(1))
            isDown1 = true;
        // 抬起了鼠标中键
        if (Input.GetMouseButtonUp(1))
            isDown1 = false;
        //// 按下鼠标右键
        //if (Input.GetMouseButtonDown(2))
        //    isDown2 = true;
        //// 抬起了鼠标右键
        //if (Input.GetMouseButtonUp(2))
        //    isDown2 = false;
        //// 缩放 Input.mouseScrollDelta.y
        m_target.localScale += Time.deltaTime * m_target.localScale * Input.mouseScrollDelta.y;
    }
    private void LateUpdate()
    {
        if (isDown1)
        {
            // 计算单位时间内鼠标的偏移量
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            Vector3 rot = new Vector3(y, -x, 0);
            float spd = 10; //速度
            m_target.Rotate(spd * rot, Space.World);
        }
        //if (isDown2)
        //{
        //    // 计算单位时间内鼠标的偏移量
        //    float x = Input.GetAxis("Mouse X");
        //    float y = Input.GetAxis("Mouse Y");
        //    float spd = 0.4f;   //速度
        //    m_target.Translate(spd * new Vector3(x, y), Space.World);
        //}
    }
}
