using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float RotateSpeed = 5f;
    public float Radius = 0.1f;
 
    private Vector2 _centre;
    private float _angle;
	private float time = 0;
	public GameObject target;
     private void Start()
     {
        _centre = target.transform.position;
		var offset = new Vector2(Mathf.Sin(0), Mathf.Cos(0)) * Radius;
        transform.position = _centre + offset;
		Debug.Log(transform.position);
     }
     private void Update()
     {
         _angle += RotateSpeed * Time.deltaTime;
         var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
         transform.position = _centre + offset;
     }
  
}
