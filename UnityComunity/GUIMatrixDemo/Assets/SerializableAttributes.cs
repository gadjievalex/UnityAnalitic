using UnityEngine;
using System.Collections;

public class SerializableAttributes : MonoBehaviour 
{
    [UnityEngine.SerializeField]
    public Test testVar = new Test();

    public int value;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
            print("You clicked the button!");

    }
}
