using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light Flash;
    public bool flashOn = false;
    // Start is called before the first frame update
    void Start()
    {
         Flash = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
//        if (Input.GetKeyDown("f")){
//             if(flashOn==false){
//             flashOn = true;
        
//         }
//         else{
//             flashOn = true;
//         }}


//         if(flashOn==true){
//             Flash.intensity = 0.1f; 
//         }
//         else if(flashOn==false){
//         Flash.intensity = 0f; 
//         }
//     }
// }
    }}