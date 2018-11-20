using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCount : MonoBehaviour {

    private CountScript counts;
    public void SetCountDown()
    {
        counts = GameObject.Find("CountDownManager").GetComponent<CountScript>();
        counts.CounterDownDone = true;
    }
}
