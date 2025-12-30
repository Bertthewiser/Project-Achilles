using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFireTest : MonoBehaviour
{
    public GameObject player;
    public GameObject Projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnFire2(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("test");
            Instantiate(Projectile, new Vector3(0, 5, 0), Quaternion.identity);
            Debug.Log("Instantiated");
        }
    }
}
