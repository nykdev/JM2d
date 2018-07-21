using UnityEngine;
using System.Collections;

public class CameraScreenResolution : MonoBehaviour {
	//public bool maintainWidth=true;
	[Range(-1,1)]
	public int AdaptPosition;


	float _defaultWidth;
	float _defaultHeight;


	Vector3 CameraPos;

	// Use this for initialization
	void Start () {
		CameraPos = Camera.main.transform.position;

		_defaultHeight = Camera.main.orthographicSize;
		_defaultWidth = Camera.main.orthographicSize * 9/16;
		
		Camera.main.orthographicSize = _defaultWidth / Camera.main.aspect;
		Camera.main.transform.position= new Vector3(CameraPos.x,CameraPos.y + AdaptPosition*(_defaultHeight-Camera.main.orthographicSize),CameraPos.z);
	}
	
	
}
