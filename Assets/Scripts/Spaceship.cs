using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
    Rigidbody2D physics;

    private void Awake(){
        this.physics = this.GetComponent<Rigidbody2D>();
    }
    private void Update() {
     if(Input.GetButtonDown("Fire1")) {
            this.Impulse();
        }   
    }
    private void Impulse() {
        this.physics.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
