using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
            Rotate('x', -1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Rotate('x', 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Rotate('y', -1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Rotate('y', 1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Rotate('z', 1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Rotate('z', -1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move('x', -1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move('x', 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Move('y', 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Move('y', -1);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move('z', 1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move('z', -1);
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

    private void Move(char axis, int scale)
    {
        float totalForce = forceMovement * scale;

        switch (axis)
        {
            case 'x':
                move_x += totalForce;
                info_move_x += totalForce;
                break;

            case 'y':
                move_y += totalForce;
                info_move_y += totalForce;
                break;

            case 'z':
                move_z += totalForce;
                info_move_z += totalForce;
                break;
        }
    }

    private void Rotate(char axis, int scale)
    {
        float totalForce = forceRotation * scale;

        switch (axis)
        {
            case 'x':
                rotate_x += totalForce;
                info_rotate_x += totalForce;
                break;

            case 'y':
                rotate_y += totalForce;
                info_rotate_y += totalForce;
                break;

            case 'z':
                rotate_z += totalForce;
                info_rotate_z += totalForce;
                break;
        }
    }
}