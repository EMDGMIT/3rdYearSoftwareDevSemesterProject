using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

    private PauseMenu thePauseMenu;


	void Start()
    {
        thePauseMenu = FindObjectOfType<PauseMenu>();
    }
	
	
	public void Pause()
    {
        thePauseMenu.PauseUnpause();
	}
}
