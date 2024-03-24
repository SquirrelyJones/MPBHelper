using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject target;

    public AnimationCurve animCurve;
    public float animTime = 0.7f;

    private float timer = 0f;

    private MPBHelper mpbHelper;
    private static readonly int _Attack = Shader.PropertyToID("_Attack");

    private void Start() {
        mpbHelper = MPBHelper.GetManager(target);
    }

    [ContextMenu("Activate")]
    public void Activate() {
        timer = animTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Mathf.Clamp(timer - Time.deltaTime, 0.0f, animTime);
        float timeFrac = 1.0f - (timer / animTime);
        float hit = animCurve.Evaluate(timeFrac);
        mpbHelper.SetFloat(_Attack, hit);
    }
}