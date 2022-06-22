using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LakeOffset : MonoBehaviour
{
    public float speed;
    MeshRenderer mRend;
    private void Awake()
    {
        mRend = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        mRend.material.mainTextureOffset = new Vector2(0f, Time.time * speed);
    }
}
