using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializedField] int speed;
  void Start(){ //Function yang akan dipanggil sekali di awal
    rb = GetComponent<Rigidbody2D>();
  }
  
  void Update(){ //Function yang dipanggil sekali tiap frame
    float x = Input.GetAxisRaw("Horizontal");
    rb.velocity = Vector2(x * 5 * Time.deltaTime, velocity.y);
    
    if(Input.GetKey(KeyCode.Space)){
      rb.AddForce(new Vector2(0, 5 * speed * Time.deltaTime));
    }
    /*if(Input.GetKey(KeyCode.D)){
      rb.AddForce(Vector2.right);
    }
    if(Input.GetKey(KeyCode.A)){
      rb.AddForce(Vector2.left);
    }*/
  }
}
