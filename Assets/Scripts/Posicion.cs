using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    int loop = 0;
    float moveSpeed = 25f;
    private void Start()
    {
        // Obtener la referencia al componente Transform del objeto actual
    }

    private void Update()
    {

        Move();

        RemoveVagon();

        Rotation();
    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0, 1, 0);
    }

    private void RemoveVagon()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (loop == 0)
            {
                Transform removeVagon = transform.Find("Vagon(3)");
                removeVagon.parent = null;
                loop++;
                moveSpeed += 5f;
            }
            else if (loop == 1)
            {
                Transform removeVagon = transform.Find("Vagon(2)");
                removeVagon.parent = null;
                loop++;
                moveSpeed += 5f;
            }
            else if (loop == 2)
            {
                Transform removeVagon = transform.Find("Vagon(1)");
                removeVagon.parent = null;
                loop++;
                moveSpeed += 5f;
            }
        }
    }

    private void Scale()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.localScale += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.localScale += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.localScale += Vector3.right;
        }
    }

    private void GetPosition()
    {
        Debug.Log("Posición x: " + this.transform.position.x);
        Debug.Log("Posición y: " + this.transform.position.y);
        Debug.Log("Posición z: " + this.transform.position.z);
    }

    private void GetRotation()
    {
        Debug.Log("Rotación x: " + this.transform.rotation.x);
        Debug.Log("Rotación y: " + this.transform.rotation.y);
        Debug.Log("Rotación z: " + this.transform.rotation.z);
    }

    private void GetScale()
    {
        Debug.Log("Escala x: " + this.transform.localScale.x);
        Debug.Log("Escala y: " + this.transform.localScale.y);
        Debug.Log("Escala z: " + this.transform.localScale.z);
    }

    private void Move()
    {
        
        float horizontalInput = Input.GetAxis("Vertical");
        float verticalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }



}
