using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public float doubleTapDelay = 0.2f;
    public float barrelRollDuration = 1.0f;

    private float time = float.MaxValue;
    private bool buttonDown = false;
    private bool inBarrelRoll = false;

    void Update()
    {
        if(!inBarrelRoll)
        {
            float bankAxis = Input.GetAxis("Bank");

            //Single axis method (For windows/keyboard)
            Vector3 newRotationEuler = transform.rotation.eulerAngles;
            newRotationEuler.z = 90 * Input.GetAxis("Bank");
            Quaternion newQuat = Quaternion.identity;
            newQuat.eulerAngles = newRotationEuler;
            transform.rotation = newQuat;

            //What we want:
            //We need a timer. If you hit he button (Axis switches from 0 to non-0) the timer starts,
            //It resets when you go from 0 to non-zero again, and does a barrel roll if you do this whitin the time limit


            if (bankAxis == 0.0f)
            {
                buttonDown = false;
            }

            //We are not at 0!
            else if (buttonDown == false)
            {
                buttonDown = true;
                if (time < doubleTapDelay)
                {
                   StartCoroutine("BarrelRollLeft");
                }
                time = 0.0f;
            }

            time += Time.deltaTime;
        
        }

        IEnumerator BarrelRollLeft()
        {
            inBarrelRoll = true;
            float t = 0.0f;

            Vector3 initialRotation = transform.rotation.eulerAngles;
            Vector3 goalRotation = initialRotation;
            goalRotation.z += 180.0f;

            Vector3 currentRotation = initialRotation;
            
            while(t < barrelRollDuration/2.0f)
            {
                currentRotation.z = Mathf.Lerp(initialRotation.z, goalRotation.z, t / (barrelRollDuration / 2.0f));
                transform.rotation = Quaternion.Euler(currentRotation);
                t += Time.deltaTime;
                yield return null;
            }

           
            t = 0;
            initialRotation = transform.rotation.eulerAngles;
            goalRotation = initialRotation;
            goalRotation.z += 180.0f;

            while (t < barrelRollDuration/2.0f)
            {
                currentRotation.z = Mathf.Lerp(initialRotation.z, goalRotation.z, t / (barrelRollDuration / 2.0f));
                transform.rotation = Quaternion.Euler(currentRotation);
                t += Time.deltaTime;
                yield return null;
            }

            inBarrelRoll = false;
            yield return null;
        }

    }
}
