using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Menu : MonoBehaviour
{
    public UnityEvent healEvent;
    public UnityEvent takeDamageEvent;
    public UnityEvent attackEvent;
    public UnityEvent chargeEvent;

    void OnGUI()
    {
        int posY = 20;
        
        if( GUI.Button(new Rect(20, posY, 150, 30), "Heal")) {
            healEvent.Invoke();
        }

        posY += 50;

        if (GUI.Button(new Rect(20, posY, 150, 30), "Take Damage")) {
            takeDamageEvent.Invoke();
        }

        posY += 50;

        if (GUI.Button(new Rect(20, posY, 150, 30), "Attack")) {
            attackEvent.Invoke();
        }

        posY += 50;

        if (GUI.Button(new Rect(20, posY, 150, 30), "Charge")) {
            chargeEvent.Invoke();
        }
    }
}
