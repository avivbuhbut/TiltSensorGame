using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
public class Jump : MonoBehaviour
{

    UduinoManager manager;

    // public Vector2 speed = new Vector2(10, 10);

    //  public Vector2 movement = new Vector2(1, 1);
    //  string intDeviceInput;

    // Use this for initialization
    int TiltSenVal;
    int potVal;
    void Start()
    {
        manager = UduinoManager.Instance;
        manager.pinMode(AnalogPin.A0, PinMode.Input);
        manager.pinMode(AnalogPin.A5, PinMode.Input);

   
    //    Rigidbody2D rigidbody2D = new Rigidbody2D();

     //   print("intDeviceInput: " + intDeviceInput);
    }

    // Update is called once per frame
    void Update()
    {

    
            
            
    }
    void FixedUpdate()
    {

        TiltSenVal = manager.analogRead(AnalogPin.A0);
        potVal = manager.analogRead(AnalogPin.A5);
        print(potVal * 0.1f % 100);

     
        
        Vector2 vec = new Vector2(potVal* 0.1f %100, TiltSenVal * 0.35f % 100);
        transform.Translate(vec * 0.8f * Time.deltaTime, Space.World);
  

    }
}


        
    
