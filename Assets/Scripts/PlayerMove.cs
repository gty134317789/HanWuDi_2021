using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    public float jumpspeed = 5;

    public float g = 10;

    public CharacterController playercontroller;

    Vector3 move;
    void Update()
    {
        float x = 0, z = 0;

        if (playercontroller.isGrounded)
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
            move = (transform.right * x + transform.forward * z) * speed;
            if (Input.GetAxis("Jump") == 1)
            {
                move.y = jumpspeed;
            }
        }
        move.y = move.y - g * Time.deltaTime;

        playercontroller.Move(move * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape) /*|| Input.GetKeyDown(KeyCode.Home)*/)
        {
            Quit();
        }


    }
    public void Quit()
    {
        //打包时不能使用
        //UnityEditor.EditorApplication.isPlaying = false;
        //测试时不能执行，打包后可以执行
        Application.Quit();
    }
}