using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class test : MonoBehaviour {

	public Camera camera_;
	public VideoPlayer videoPlayer;

	void Awake(){
		camera_ = Camera.main;
		videoPlayer = GetComponent <VideoPlayer> ();
		videoPlayer.Play ();
		videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
	}

	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
		}else if(Input.GetKey (KeyCode.Space)){
			videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
			videoPlayer.targetCamera = camera_;
		}
	}
}