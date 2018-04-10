using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour {

    Animator anim;

    //This variable has the keyword "public" in front of it, whcich in this context means that has become a property which all other classes can get access to.
    //This also means that it is accessable in the inspector in Unity.
    public float speed = 0;




    //Event that happens before start, one time during the lifetime of the Gameobject
    private void Awake() {
        
    }

    //one time
    void Start () {
        anim = GetComponent<Animator>();
	}


    //Every frame (Framerate varies between different computers).
	void Update () {

        //The Input class handles all inputs from the user. Check the documentation pages online to understand how expansive it is ;)
        if(Input.GetKeyDown(KeyCode.Space)) {
            anim.Play("Bounce", 0);
        }

        //Here we utilize Time.deltatime to compansate for the different framerates by multiplying the speed with how long the last frame took to compute.
        //This is a very typical technique when working with values that should change at a constant pase, or when doing locomotive motion (As in this example).
        transform.position += Vector3.forward * Time.deltaTime * speed;
	}

    //After ever update
    //Very typically used when some calculation depends on the rest of the game having reached a "conclusion" the frame in question.
    private void LateUpdate() {
        
    }

    //This is a self made Function (or Method) which can be called from other classes (notice the keyword "public" again)
    public void PlayAnimation() {
        anim.Play("Bounce", 0);
    }

    //Like PlayAnimation(), this is a function I made to show parameters (in this case a and b).
    //Unlike PlayAnimation() this Function has a return type of "int", this means that the function needs to conclude and return some int value.
    int Add(int a, int b) {
        return a + b;
    }
}
