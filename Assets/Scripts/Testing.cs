using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleCalendarUnity;

public class Testing : MonoBehaviour
{
    public Calendar calendar = new Calendar();
    
    private void Update()
    {
        calendar.Main();
    }

}
