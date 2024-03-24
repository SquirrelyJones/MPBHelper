using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MPBHelper : MonoBehaviour
{
	//private MaterialPropertyBlock mpb = null;
	private MaterialPropertyBlock mpb = null;

	private Renderer thisRenderer;
	private bool hasRenderer = false;

	private TextMeshPro thisTMP;
	private bool hasTMP = false;

	private bool initialized = false;

	private bool update = false;

	void Awake() {
		Initialize();
	}

	void OnEnable() {
		Initialize();
	}

	private void OnDestroy() {
		MPBManager.RemoveUpdate(this);
	}

	private void Initialize() {
#if UNITY_EDITOR
		if(Application.isPlaying && initialized) return;
#else
		if (initialized) return;
#endif

		if (mpb == null) mpb = new MaterialPropertyBlock();

		if (thisRenderer == null) thisRenderer = gameObject.GetComponent<Renderer>();
		hasRenderer = (thisRenderer != null);

		if (thisTMP == null) thisTMP = gameObject.GetComponent<TextMeshPro>();
		hasTMP = (thisTMP != null);


#if UNITY_EDITOR
		if (Application.isPlaying) initialized = true;
#else
		initialized = true;
#endif
	}

	private void AddUpdate() {
		if (update) return;
		MPBManager.AddUpdate(this);
		update = true;
	}

	// Float

	public static void SetFloat(GameObject go, string param, float value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetFloat(param, value);
	}

	public static void SetFloat(GameObject go, int param, float value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetFloat(param, value);
	}

	public void SetFloat( string param, float value) {
		Initialize();
		mpb.SetFloat(param, value);
		AddUpdate();
	}

	public void SetFloat(int param, float value) {
		Initialize();
		mpb.SetFloat(param, value);
		AddUpdate();
	}

	// Float Array

	public static void SetFloatArray(GameObject go, string param, float[] value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetFloatArray(param, value);
	}

	public static void SetFloatArray(GameObject go, int param, float[] value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetFloatArray(param, value);
	}

	public void SetFloatArray(int param, float[] value) {
		Initialize();
		mpb.SetFloatArray(param, value);
		AddUpdate();
	}

	public void SetFloatArray(string param, float[] value) {
		Initialize();
		mpb.SetFloatArray(param, value);
		AddUpdate();
	}

	// Vector

	public static void SetVector(GameObject go, string param, Vector4 value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetVector(param, value);
	}

	public static void SetVector(GameObject go, int param, Vector4 value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetVector(param, value);
	}

	public void SetVector(string param, Vector4 value) {
		Initialize();
		mpb.SetVector(param, value);
		AddUpdate();
	}

	public void SetVector(int param, Vector4 value) {
		Initialize();
		mpb.SetVector(param, value);
		AddUpdate();
	}

	// Vector Array

	public static void SetVectorArray(GameObject go, string param, Vector4[] value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetVectorArray(param, value);
	}

	public static void SetVectorArray(GameObject go, int param, Vector4[] value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetVectorArray(param, value);
	}

	public void SetVectorArray(string param, Vector4[] value) {
		Initialize();
		mpb.SetVectorArray(param, value);
		AddUpdate();
	}

	public void SetVectorArray(int param, Vector4[] value) {
		Initialize();
		mpb.SetVectorArray(param, value);
		AddUpdate();
	}

	// Color

	public static void SetColor(GameObject go, string param, Color value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetColor(param, value);
	}

	public static void SetColor(GameObject go, int param, Color value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetColor(param, value);
	}

	public void SetColor(string param, Color value) {
		Initialize();
		mpb.SetColor(param, value);
		AddUpdate();
	}

	public void SetColor(int param, Color value) {
		Initialize();
		mpb.SetColor(param, value);
		AddUpdate();
	}

	// RenderTexture

	public static void SetTexture(GameObject go, string param, RenderTexture value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetTexture(param, value);
	}

	public static void SetTexture(GameObject go, int param, RenderTexture value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetTexture(param, value);
	}

	public void SetTexture(string param, RenderTexture value) {
		Initialize();
		mpb.SetTexture(param, value);
		AddUpdate();
	}

	public void SetTexture(int param, RenderTexture value) {
		Initialize();
		mpb.SetTexture(param, value);
		AddUpdate();
	}

	// Texture

	public static void SetTexture(GameObject go, string param, Texture value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetTexture(param, value);
	}

	public static void SetTexture(GameObject go, int param, Texture value) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetTexture(param, value);
	}

	public void SetTexture(string param, Texture value) {
		Initialize();
		mpb.SetTexture(param, value);
		AddUpdate();
	}

	public void SetTexture(int param, Texture value) {
		Initialize();
		mpb.SetTexture(param, value);
		AddUpdate();
	}

	// Matrix

	public static void SetMatrix(GameObject go, string param, Matrix4x4 matrix) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetMatrix(param, matrix);
	}

	public static void SetMatrix(GameObject go, int param, Matrix4x4 matrix) {
		MPBHelper mpbManager = GetManager(go);
		if (mpbManager == null) return;
		mpbManager.SetMatrix(param, matrix);
	}

	public void SetMatrix(string param, Matrix4x4 matrix) {
		Initialize();
		mpb.SetMatrix(param, matrix);
		AddUpdate();
	}

	public void SetMatrix(int param, Matrix4x4 matrix) {
		Initialize();
		mpb.SetMatrix(param, matrix);
		AddUpdate();
	}

	// updates

	public void UpdatePropertyBlock() {
		Initialize();
		
		if(hasRenderer) thisRenderer.SetPropertyBlock(mpb);

		if (hasTMP) {
			// There may be multiple changing sub renderers for text meshes
			Renderer[] renderers = GetComponentsInChildren<Renderer>();
			for( int i = 0; i < renderers.Length; i++) {
				renderers[i].SetPropertyBlock(mpb);
			}
			/*
			foreach (Transform child in transform) {
				Renderer childRenderer = child.GetComponent<Renderer>();
				if (childRenderer != null) {
					childRenderer.SetPropertyBlock(mpb);
				}
			}
			*/
		}

		update = false;
	}

	public static MPBHelper GetManager( GameObject gameObject) {
		if(gameObject == null) return null;

		MPBHelper mpbManager = gameObject.GetComponent<MPBHelper>();

		if (mpbManager == null) {
			mpbManager = gameObject.AddComponent<MPBHelper>();
		}

		mpbManager.Initialize();

		return mpbManager;
	}

	public static MPBHelper GetManager(Transform trans) {
		if (trans == null) return null;
		return GetManager(trans.gameObject);
	}
}
