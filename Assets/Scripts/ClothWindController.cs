using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothWindController : MonoBehaviour
{
    private Cloth cloth;
    private const float MIN_ACCEL = 0.1f;
    private const float MAX_ACCEL = 7.0f;
    private float accel = MIN_ACCEL;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        cloth = GetComponent<Cloth>();
        accel = cloth.externalAcceleration.z;
        //Debug.Log(transform.eulerAngles);
        //Debug.Log(transform.rotation);
        Vector3 vec = transform.up;
        Debug.Log(vec);
        vec =  vec * -7;
        Debug.Log(vec);
        direction = vec;
        //cloth.externalAcceleration = vec;
    }

    // Update is called once per frame
    void Update()
    {
        SetAccel(-0.004f);
    }

    private void OnMouseDown()
    {
        SetAccel(0.5f);
    }

    private void SetAccel(float amount) 
    {
        if(accel + amount < MIN_ACCEL || accel + amount > MAX_ACCEL) {
            return;
        }
        accel += amount;
        cloth.externalAcceleration = Vector3.ClampMagnitude(direction,accel);
        //Debug.Log(cloth.externalAcceleration);
    }
}
