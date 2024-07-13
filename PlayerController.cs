using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    float speed = 7 ;
    float rotationSpeed = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerManager.levelStarted)
            return;
        if(PlayerManager.gameOver)
            return;
        transform.Translate(0,0,speed*Time.deltaTime);
        if(Touchscreen.current != null){
            Vector2 delta = Touchscreen.current.primaryTouch.delta.ReadValue();
            transform.Rotate(0,0, delta.x * rotationSpeed);
        }
    }
}
