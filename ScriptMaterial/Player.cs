using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] int speed;
    public int JumpSpeed;
    public bool isJump = false;
    public GameObject FirePoint;
    public bool FacingRight = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(x*5*speed*Time.fixedDeltaTime,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isJump == false){
            rb.AddForce(new Vector2(0,50*JumpSpeed*Time.deltaTime));
        }
        if(x > 0.01f && FacingRight){
            transform.localScale = Vector2.one;
            Flip();
            
        }
        else if(x < -0.01f && !FacingRight){
            transform.localScale = new Vector2(-1,1);
            Flip();
        }
        /*if(Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector2.right);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector2.left);
        }
        */
    }

    public void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="lantai"){
            isJump = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "lantai"){
            isJump = true;
        }
    }

    void Flip(){
        FacingRight = !FacingRight;
        FirePoint.transform.Rotate(0,180,0);
    }
}
