using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour {

    public Text Object0Text;
    public Text Object1Text;
    public Text Object2Text;

    private PlayerController playerController;

    // Use this for initialization
    void Start () {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Debug.Log(playerController.objectCollected[0].ToString());
        Debug.Log(playerController.objectCollected[1].ToString());
        Debug.Log(playerController.objectCollected[2].ToString());

        Object0Text.text = playerController.objectCollected[0].ToString();
        Object1Text.text = playerController.objectCollected[1].ToString();
        Object2Text.text = playerController.objectCollected[2].ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
