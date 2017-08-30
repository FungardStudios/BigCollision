using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSript : MonoBehaviour {

	public Camera camera_;
	public VideoPlayer videoPlayer;

	void Awake(){
		camera_ = Camera.main;
		videoPlayer = GetComponent <VideoPlayer> ();
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			videoPlayer.Play ();
		} else if (Input.GetKey (KeyCode.Tab)) {
			videoPlayer.Stop ();
		}else if (Input.GetKey (KeyCode.P)) {
			videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
			videoPlayer.targetCamera = camera_;
		} else if (Input.GetKey (KeyCode.Escape)) {
			videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
		}
	}
}
