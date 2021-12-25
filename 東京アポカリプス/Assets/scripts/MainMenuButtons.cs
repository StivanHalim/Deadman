using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour {

    public SpriteRenderer Background;
    public SpriteRenderer Background1;
    bool on = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackgroundActivate()
    {
        if (on == true)
        {
            on = false;
        }
        else
        {
            on = true;
        }

        if (on == true)
        {
            Background.enabled = false;
            Background1.enabled = true;
        }
        else
        {
            Background.enabled = true;
            Background1.enabled = false;
        }
    }
}
