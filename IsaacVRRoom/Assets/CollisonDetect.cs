using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonDetect : MonoBehaviour
{
 void OnTriggerEnter(Collision other){
	Destroy(gameObject);
	Destroy(other.gameObject);
}

}
