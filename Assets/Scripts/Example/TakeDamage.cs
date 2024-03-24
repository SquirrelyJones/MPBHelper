using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private Health health;
    
    public GameObject target;

    public int damageAmount = 10;

    public AnimationCurve animCurve;
    public float animTime = 0.25f;

    private float timer = 0f;

    private MPBHelper mpbHelper;
    private static readonly int _Hit = Shader.PropertyToID("_Hit");

    private void Awake() {
        health = GetComponent<Health>();
    }

    private void Start() {
        mpbHelper = MPBHelper.GetManager(target);
    }

    [ContextMenu("Activate")]
    public void Activate() {
        timer = animTime;
        health.TakeDamage(damageAmount);
    }

	// Update is called once per frame
	void Update() {
        timer = Mathf.Clamp(timer - Time.deltaTime, 0.0f, animTime);
        float timeFrac = 1.0f - (timer / animTime);
        float hit = animCurve.Evaluate(timeFrac);
        mpbHelper.SetFloat(_Hit, hit);
    }
}
