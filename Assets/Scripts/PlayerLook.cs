using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    public Vector2 camerainput;
    public Quaternion cameradirect;
    public Vector3 cameradirection;
    public Vector3 playerdirection;
    public GameObject Camera;
    public GameObject Player;
    public float RotationX;
    public float RotationY;
    
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Mathf.Clamp(RotationY, -90, 90);
    }

    private void Update()
    {
        RotationX += -camerainput.y;
        RotationY += camerainput.x;
        cameradirection = new Vector3(RotationX, 0, 0);
        playerdirection = new Vector3(0, RotationY, 0);
        cameradirection.x = Mathf.Clamp(RotationX, -90, 90);
        Camera.transform.localEulerAngles = cameradirection;
        Player.transform.localEulerAngles = playerdirection;
        

    }

    // Update is called once per frame
    void OnLook(InputValue value)
    {
        camerainput = value.Get<Vector2>();
    }
}
