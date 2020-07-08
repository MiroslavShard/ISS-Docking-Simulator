using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Force")]
    public float forceMovement = 0.1f;
    public float forceRotation = 0.1f;

    [Header("Movement")]
    public float move_x = 0f;
    public float move_y = 0f;
    public float move_z = 0f;

    [Header("Rotation")]
    public float rotate_x = 0f;
    public float rotate_y = 0f;
    public float rotate_z = 0f;

    [Header("Information")]
    public double info_move_x = 0f;
    public double info_move_y = 0f;
    public double info_move_z = 0f;
    [Space(5)]
    public double info_rotate_x = 0f;
    public double info_rotate_y = 0f;
    public double info_rotate_z = 0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            RotateX(-1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            RotateX(1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            RotateY(-1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            RotateY(1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            RotateZ(1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RotateZ(-1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveX(-1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveX(1);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MoveY(1);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            MoveY(-1);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveZ(1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveZ(-1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            forceRotation = 0.25f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            forceRotation = 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            forceRotation = 1f;
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * move_x * Time.deltaTime);
        transform.Translate(Vector3.up * move_y * Time.deltaTime);
        transform.Translate(Vector3.forward * move_z * Time.deltaTime);

        transform.Rotate(Vector3.right * rotate_x * Time.deltaTime);
        transform.Rotate(Vector3.up * rotate_y * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotate_z * Time.deltaTime);
    }

    private void RotateX(int scale)
    {
        rotate_x += forceRotation * scale;
        info_rotate_x += forceRotation * scale;
    }

    private void RotateY(int scale)
    {
        rotate_y += forceRotation * scale;
        info_rotate_y += forceRotation * scale;
    }

    private void RotateZ(int scale)
    {
        rotate_z += forceRotation * scale;
        info_rotate_z += forceRotation * scale;
    }

    private void MoveX(int scale)
    {
        move_x += forceMovement * scale;
    }

    private void MoveY(int scale)
    {
        move_y += forceMovement * scale;
    }

    private void MoveZ(int scale)
    {
        move_z += forceMovement * scale;
    }
}