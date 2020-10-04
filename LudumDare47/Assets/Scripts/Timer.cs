using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float maxFuel = 20f;
    public float fuel = 20f;

    public CanvasManager canvasManager;
    public Transform needleTransform;

    private const float MAX_FUEL_ANGLE = -100;
    private const float ZERO_FUEL_ANGLE = 100;

    private bool fuelIsOut = false;
    
    // Start is called before the first frame update


    private void Awake()
    {
        //needleTransform = transform.Find("needle");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fuel > 0)
        {
            fuel -= Time.deltaTime;

            if(fuel > maxFuel)
            {
                fuel = maxFuel;
            }

            needleTransform.eulerAngles = new Vector3(0, 0, GetFuelRotation());
        }
        else
        {
            if (fuelIsOut == false)
            {
                NoFuel();
            }
            

        }
    }

    private float GetFuelRotation()
    {
        float totalAngleSize = ZERO_FUEL_ANGLE - MAX_FUEL_ANGLE;

        float fuelNormalized = fuel / maxFuel;

        return ZERO_FUEL_ANGLE - fuelNormalized * totalAngleSize;
    }

    private void NoFuel()
    {
        fuelIsOut = true;

        Debug.Log("Game Over");
        canvasManager.GameOver();
    }
}
