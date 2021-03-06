﻿using UnityEngine;
using System;
using System.Collections;

public class PictureFrame : MonoBehaviour {

    public PictureFrame pictureFrame;
    public GameObject SceneVW;
    public Vector3 origin;
    public Material sky;

    // Use this for initialization
    void Start ()
    {
        origin = transform.position;
    }

    // Update is called once per frame

    void Update ()
    {

	}

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
            PictureFrame newFrame = Instantiate(pictureFrame, origin, Quaternion.identity) as PictureFrame;
        }

        if (col.gameObject.tag == "Head")
        {
            SceneVW.SetActive(false);
            RenderSettings.skybox = sky;
        }
    }
}
