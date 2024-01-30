using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveDirection;
    public bool IsControling => moveDirection != Vector3.zero;

    private void Update()
    {
        if (IsControling)
        {
            Debug.Log("¿Ãµø ¡ﬂ");
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    void OnMove(InputValue inputValue)
    {
        if(inputValue != null)
            moveDirection = inputValue.Get<Vector3>();
        else
            moveDirection = Vector3.zero;
    }
}
