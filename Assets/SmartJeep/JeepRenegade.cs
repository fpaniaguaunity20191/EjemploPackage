using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeepRenegade : MonoBehaviour {
    public float speed;
    public float angularSpeed;
    public GameObject target;
    private bool forward = true;

    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (forward == false) {//Condición alternativa if (!forward)
            transform.Rotate(new Vector3(0, angularSpeed * Time.deltaTime, 0));
        }
	}
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name != "Floor") {
            if (collision.gameObject == target) {
                speed = 0;
                angularSpeed = 0;
            }
            forward = !forward;
            speed = speed * -1;
        }
    }
}
