using UnityEngine;
using System.Collections;

public class DoNotDestroyOnload : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}

}
