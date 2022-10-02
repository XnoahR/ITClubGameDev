using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Instantiate(Bullet,transform.position,transform.rotation);
        }
    }
}
