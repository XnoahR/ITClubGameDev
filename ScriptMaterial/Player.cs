using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializedField] int speed;
  [SerializedField] int jumpSpeed;
  [SerializedField] bool isJump = false;
  
  void Start(){ //Function yang akan dipanggil sekali di awal
    rb = GetComponent<Rigidbody2D>();
  }
  
  void Update(){ //Function yang dipanggil sekali tiap frame
    float x = Input.GetAxisRaw("Horizontal");
    rb.velocity = Vector2(x * 5 * speed * Time.deltaTime, rb.velocity.y);
    
    if(Input.GetKeyDown(KeyCode.Space) && isJump == false){
      rb.AddForce(new Vector2(0, 50 * jumpSpeed * Time.deltaTime));
    }
    /*if(Input.GetKey(KeyCode.D)){
      rb.AddForce(Vector2.right);
    }
    if(Input.GetKey(KeyCode.A)){
      rb.AddForce(Vector2.left);
    }*/
  }
  
  public void OnCollisionEnter2D(Collision2D other){
    if(other.gameObject.tag == "lantai"){
      isJump = false;
    }
  }
  
  public void OnCollisionExit2D(Collision2D other){
    if(other.gameObject.tag == "lantai"){
      isJump = true;
    }
  }
}
