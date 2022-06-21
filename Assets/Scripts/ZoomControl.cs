using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomControl : MonoBehaviour
{
    private CinemachineFollowZoom cineZoom;

    private void Awake()
    {
        cineZoom = GetComponent<CinemachineFollowZoom>();
    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            cineZoom.m_MinFOV = Mathf.Lerp(cineZoom.m_MinFOV, 10f, 0.1f);
        }
        else
        {
            cineZoom.m_MinFOV = Mathf.Lerp(cineZoom.m_MinFOV, 45f, 0.1f);
        }
    }
}
