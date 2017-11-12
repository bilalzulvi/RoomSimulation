using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDestinationMovement : MonoBehaviour {

    public string nama;
    public enum igender
    {
        Pria, Wanita
    }
    public igender gender;

    public int positionFloor = 0;
    public string NameRoom = "Home";

    public List<Vector3> listDestination;
    public Transform transformMe;
    // Use this for initialization
    public GameObject personWalking;
	void Start () {
        transformMe = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
      
    }

    public void inputListDestination(List<Vector3> listi)
    {
        listDestination = listi;
    }

    public void changeDestination()
    {
        int random = UnityEngine.Random.Range(1, 10);
        Invoke("changeInvokeDestinaton", random);
    }

    public void changeInvokeDestinaton()
    {
        transform.position = transformRandomPosition();
    }

    Vector3 transformRandomPosition()
    {
        Vector3 ss;
        int totalCount = listDestination.Count;
        int random = UnityEngine.Random.Range(0, totalCount);
        Debug.Log(this.name +" ganti posisi");
        ss = listDestination[random];
        return ss;
    }


    //----------------
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.name == personWalking.name)
        {
          //  Debug.Log("person arrive in destination");
            changeDestination();
        }
    }

    public void AccessDoor(int positionFloorBefore, int positionFloorAfter, string NameRoomBefore, string NameRoomAfter)
    {
        
        //delete atau input ke list karyawan
        if (NameRoom == "Home")
        {
            GameManager.addListStaff(this);
        }
        if (NameRoom == "Reception Room" && NameRoomBefore == "Home")
        {
            GameManager.delListStaff(this);
        }
        //---------------
        //Debug.Log("berhasil masuk pintau");
        if (positionFloor == positionFloorAfter)
        {
            positionFloor = positionFloorBefore;
        }
        else
        {
            positionFloor = positionFloorAfter;
        }

        if (NameRoom == NameRoomBefore)
        {
            NameRoom = NameRoomAfter;
        }
        else
        {
            NameRoom = NameRoomBefore;
        }

       // Debug.Log(this.name + " berada di lantai " + positionFloor + " dan di ruang " +NameRoom);
    }

   
}
