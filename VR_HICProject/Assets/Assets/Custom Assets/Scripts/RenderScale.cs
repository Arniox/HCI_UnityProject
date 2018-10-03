using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RenderScale : MonoBehaviour {

    [SerializeField] private float m_RenderScale = 1.5f;

	// Use this for initialization
	void Start () {
        XRSettings.eyeTextureResolutionScale = m_RenderScale;
	}
}
