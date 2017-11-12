using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

    // Use this for initialization
    public Transform myCamera;
    public Button buttonLantai1;
    public Button buttonLantai2;
    public Button buttonExit;

    private Vector3 posisiCamera1 = new Vector3(-3.5f , 23, 0);
    private Vector3 posisiCamera2 = new Vector3(28.4f, 30, 0);

    public GameManager gameManager;

	void Start () {
        buttonLantai1.onClick.AddListener(toFirstFloor);
        buttonLantai2.onClick.AddListener(toSecondFloor);
        buttonExit.onClick.AddListener(toExitProgram);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void toFirstFloor()
    {
        Debug.Log("anda dilantai 1");
        myCamera.position = posisiCamera1;
        gameManager.uiStatusBeDisplay = 1;
        gameManager.displayNameFloor();
    }
    void toSecondFloor()
    {
        Debug.Log("anda dilantai 2");
        myCamera.position = posisiCamera2;
        gameManager.uiStatusBeDisplay = 2;
        gameManager.displayNameFloor();
    }

    void toExitProgram()
    {
        Application.Quit();
    }

}
