using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GUIButtons : MonoBehaviour
{

    public Animator anim;

	public GameObject beamleft;
	public GameObject beamright;


    private void Start()
    {

        anim = GetComponent<Animator>();

    }


    void OnGUI()
    {

        if (GUI.Button(new Rect(10, 20, 100, 50), "Reset"))
        {
            Debug.Log("Clicked the button with an Reset");

            //anim.SetTrigger("dance1");

        }
        if (GUI.Button(new Rect(10, 60, 100, 50), "Outer HCAL"))
        {
            Debug.Log("Clicked the button with an Outer HCAL");

            //anim.SetTrigger("dance2");

        }

        if (GUI.Button(new Rect(10, 100, 100, 50), "Inner HCAL"))
        {
            Debug.Log("Clicked the button with an Inner HCAL");

            anim.SetTrigger("dance3");

        }

        if (GUI.Button(new Rect(10, 140, 100, 50), "EMCal + Tracking"))
        {
            Debug.Log("Clicked the button with EMCal + Tracking");

            //anim.SetTrigger("dance4");

        }


        if (GUI.Button(new Rect(10, 180, 100, 50), "Solenoid"))
        {
            Debug.Log("Clicked the button with an Solenoid");

            //anim.SetTrigger("dance5");

        }


        if (GUI.Button(new Rect(10, 220, 100, 50), "Collision Event"))
        {
            Debug.Log("Clicked the button with an Collision Event");

			beamleft.SetActive(false);
			beamleft.SetActive(true);
			beamright.SetActive(false);
			beamright.SetActive(true);

            //anim.SetTrigger("dance6");
        }
    }
}