using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    private const float hoursToDegrees = 360f / 12f;
    private const float minutesToDegrees = 360f / 60f;
    private const float secondsToDegrees = 360f / 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime now = System.DateTime.Now;
        hourHand.localRotation = Quaternion.Euler(0f, 0f, now.Hour * hoursToDegrees + now.Minute / 2f);
        minuteHand.localRotation = Quaternion.Euler(0f, 0f, now.Minute * minutesToDegrees);
        secondHand.localRotation = Quaternion.Euler(0f, 0f, now.Second * secondsToDegrees);
    }
}
