using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothWindController : MonoBehaviour
{
    private Cloth cloth;
    private const float MIN_ACCEL = 0.1f;
    private const float MAX_ACCEL = 7.0f;
    private float accel = MIN_ACCEL;

    // Start is called before the first frame update
    void Start()
    {
        cloth = GetComponent<Cloth>();
        accel = cloth.externalAcceleration.z;
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
        cloth.externalAcceleration = new Vector3(MIN_ACCEL,MIN_ACCEL,accel);
        Debug.Log(cloth.externalAcceleration);
    }
}
