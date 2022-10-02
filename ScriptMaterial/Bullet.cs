using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField] private float BulletSpeed;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right*Time.fixedDeltaTime*BulletSpeed);
    }
}
