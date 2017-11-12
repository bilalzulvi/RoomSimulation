using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPersonDestination : MonoBehaviour {

    // Use this for initialization
    public PersonDestinationMovement personDestinationMovement;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AccesDoor(int positionFloorBefore, int positionFloorAfter, string NameRoomBefore, string NameRoomAfter)
    {
        personDestinationMovement.AccessDoor(positionFloorBefore, positionFloorAfter, NameRoomBefore, NameRoomAfter);       
    }

   
}
