using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject target;

    public int health = 100;

    private MPBHelper mpbHelper;
    private static readonly int _Health = Shader.PropertyToID("_Health");

    private void Start() {
        mpbHelper = MPBHelper.GetManager(target);
        ApplyHealth();
    }

    public void Heal() {
        health = 100;
        ApplyHealth();
    }

    public void TakeDamage(int damage) {
        health = Mathf.Max(0, health - damage);
        ApplyHealth();
    }
    
    private void ApplyHealth() {
        mpbHelper.SetFloat(_Health, (float)health / 100f);
    }

}
