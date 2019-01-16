using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    public enum TU {Seconds,Minutes,Hours}
    public TU TimeUnit;


    public float CyclePerUnit;
    float time;

	void Update ()
    {
        //the circle have 360 degree so to complete 1 cycle in 1 minute it need 6 degree/second
        time = 6 / CyclePerUnit * Time.deltaTime;
      switch (TimeUnit)
      {
            case TU.Seconds:
                transform.Rotate(time*60, 0, 0);
                break;
            case TU.Minutes:
                transform.Rotate(time, 0, 0);
                break;
            case TU.Hours:
                transform.Rotate(time* 0.0166667f, 0, 0);
                break;
        }
    }
}
