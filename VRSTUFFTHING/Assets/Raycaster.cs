using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour {

    private void Update() {
        Debug.DrawRay(transform.position, transform.forward * 15, Color.red);

        //This is a declaration of an empty variable of Type RaycastHit.
        //This means that we have declared some use for this later, but have yet to utilize it in any way.
        RaycastHit hit;

        //Here I'm doing lots of stuff simultaniously... sorry
        //An if statement is a way of checking wheither or not something is true or not. If true, the code inside the Curly Brackets{} will run.
        //Otherwise the code will skip past and continue whichever codeblock it is in.

        //Physics.Raycast() is a function you can google to learn more about (or select it and press F12 to look into the class it belongs to)
        //print() is a fucntion which writes to the console window in Unity, use this very often!
        //GetComponent is a way of getting the reference to some other component in the GameObject that we are currently in.
        if(Physics.Raycast(transform.position, transform.forward, out hit)) {
            print("Yey, we hit " + hit.collider.name);
            if (hit.collider.GetComponent<AnimTrigger>()) {
                print("And the thing has a Trigger");
                hit.collider.GetComponent<AnimTrigger>().PlayAnimation();
            }
        }
    }
}