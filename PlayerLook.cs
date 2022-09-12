using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input){

        float mouseX = input.x;
        float mouseY = input.y;

        //calcula a rotacao da camera para cima e baixo

        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f); //nao vai deixar a camera clampar, estabelece um limite

        //aplica isso a camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //rotacionar o player para olhar direita e esquerda~
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
        
    }
}
