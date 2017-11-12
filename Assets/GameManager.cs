using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // Use this for initialization
    //public GameObject objectPerson;

    //ListTarget
    public List<Vector3> listDestination;
    //public List<Transform> ListTargetPosition = new List<Transform>();
    public PersonDestinationMovement person1;
    public PersonDestinationMovement person2;
    public PersonDestinationMovement person3;
    public PersonDestinationMovement person4;
    public PersonDestinationMovement person5;
    public PersonDestinationMovement person6;
    public PersonDestinationMovement person7;
    public PersonDestinationMovement person8;
    public PersonDestinationMovement person9;
    public PersonDestinationMovement person10;
    public PersonDestinationMovement person11;
    public PersonDestinationMovement person12;
    public PersonDestinationMovement person13;
    public PersonDestinationMovement person14;
    public PersonDestinationMovement person15;

    public Transform targetPosition;

    //ui list staff
    public static List<PersonDestinationMovement> listStaff = new List<PersonDestinationMovement>();
    public  GameObject nameStaffPrefab;
    public GameObject panelName;

  
    public int uiStatusBeDisplay;
    public GameObject totalStaff;

    void Start () {

        int screenHeight = Screen.height *2 ;
        int screenWidth = Screen.height / 16 * 9*2;
        Screen.SetResolution(screenHeight, screenWidth, false);
        

        int countTargetPosition = targetPosition.childCount;
        
        for (int i=0; i < countTargetPosition; i++)
        {
            listDestination.Add(targetPosition.GetChild(i).position);
        }

        //input list vector to persondestinationmovement class
        person1.inputListDestination(listDestination);
        person1.changeDestination();

        person2.inputListDestination(listDestination);
        person2.changeDestination();

        person3.inputListDestination(listDestination);
        person3.changeDestination();

        person4.inputListDestination(listDestination);
        person4.changeDestination();

        person5.inputListDestination(listDestination);
        person5.changeDestination();

        person6.inputListDestination(listDestination);
        person6.changeDestination();

        person7.inputListDestination(listDestination);
        person7.changeDestination();

        person8.inputListDestination(listDestination);
        person8.changeDestination();

        person9.inputListDestination(listDestination);
        person9.changeDestination();

        person10.inputListDestination(listDestination);
        person10.changeDestination();

        person11.inputListDestination(listDestination);
        person11.changeDestination();

        person12.inputListDestination(listDestination);
        person12.changeDestination();

        person13.inputListDestination(listDestination);
        person13.changeDestination();

        person14.inputListDestination(listDestination);
        person14.changeDestination();

        person15.inputListDestination(listDestination);
        person15.changeDestination();


        //int i = targetPosition.childCount;
        //ListTargetPosition.Add(targetPosition.GetChild(2));
        //Debug.Log(ListTargetPosition[0].position);

        //person1Position.position =  transformRandomPosition().position;

        // person.rotation = Quaternion.LookRotation(listPintuRuang[destinationRuanga].position);
        // ... Get three random numbers.
        //     Always 5, 6, 7, 8 or 9.
       
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(UnityEngine.Random.Range(1, 201));
        //person.AddForce(transform.forward * velocity);
        //  person.velocity = person.transform.forward * 4f ;
    }
    public void displayNameFloor()
    {
        
        if (uiStatusBeDisplay == 1)
        {
           
            displayName(1);
           
        }
        else
        {
            displayName(2);
           
        }

       
    }
   
    public  void displayName(int xx)
    {
       // Debug.Log("display berhasil");
        int ii;
        ii = 0; 

            foreach (Transform child in panelName.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

            if (listStaff.Count == 0) return;
            for (int i = 0; i < listStaff.Count; i++)
            {
                if (listStaff[i].positionFloor == xx)
                {
                    GameObject aa = (GameObject)Instantiate(nameStaffPrefab);
                    aa.transform.SetParent(panelName.transform);
                    aa.transform.localScale = new Vector3(1, 1, 1);
                    aa.transform.Find("Text").GetComponent<Text>().text = listStaff[i].nama + " ( " + listStaff[i].gender + " )";

                //if (listStaff[i].gender+"" == "Pria")
                //{
                //    aa.transform.Find("Text").GetComponent<Text>().color = Color.green;

                //}
                //else
                //{
                //    aa.transform.Find("Text").GetComponent<Text>().color = Color.magenta;

                //}

                ii = ii + 1;
                }
            }
        totalStaff.GetComponent<Text>().text = ii + " Person";
    }


    public static void addListStaff(PersonDestinationMovement xx)
    {
        listStaff.Add(xx);
       // Debug.Log("total list staf = "+ listStaff.Count);      
    }

    public static void delListStaff(PersonDestinationMovement xx)
    {
        listStaff.Remove(xx);
    }
}