using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAccess : MonoBehaviour {

    // Use this for initialization
    public int positionFloorBefore ;
    public int positionFloorAfter;
    public string NameRoomBefore;
    public string NameRoomAfter;

    

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Person")       
        {
            Debug.Log(other.gameObject.name + "masuk pintu");
            TargetPersonDestination person1 = other.GetComponent<TargetPersonDestination>();
            //PersonDestinationMovement person1 = other.gameObject.GetComponent<PersonDestinationMovement>();
            person1.AccesDoor(positionFloorBefore, positionFloorAfter, NameRoomBefore, NameRoomAfter);
          
        }
    }
}

