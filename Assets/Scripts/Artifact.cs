using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Artifact : MonoBehaviour
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject poof;
    public GameObject target;
    public AudioClip sound;
    public bool collected = false;
    public float speed = 10f;
        
  
    public void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        // ^-- exactly what I was planning!
        //I'm using numbers here as I only plan to have one key-like object... I'd totally make my 
        //own Vector3 object for reusability had it been required...
        //Trying to implement a rotation AND height change
        transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Sin(Time.time * 1.85f)*.005f, transform.position.z);
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
       // Vector3 heightChange = new Vector3(target.position.x, 3.91f + Mathf.Sin(Time.time * 1.2f));
        //transform.position = heightChange;
        //Vector3 myInitialVector = new Vector3(19.02f, 3.91f + Mathf.Sin(Time.time * 1.2f), 14.57f);
        //var myRotationQuat = Quaternion.AngleAxis(10, Vector3.right);
        //Vector3 myRotatedVector = myRotationQuat * myInitialVector;
        //transform.position = myRotatedVector;
    }

	public void OnArtifactClicked()
	{
        
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Vector3 ArtifactLocation = transform.position;
        Object.Instantiate(poof, ArtifactLocation, Quaternion.Euler(-90f, 0f, 0f));
        AudioSource.PlayClipAtPoint(sound, transform.position);
        // Call the Unlock() method on the Door
        // exitDoor.Unlock();
        // Set the Key Collected Variable to true
        collected = true;
        GameObject.Find("SceneLogic").GetComponent<UnlockScript>().ArtifactCollected();
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Object.DestroyImmediate(this.gameObject, true);
        //print("Removed key!);
        RemoveKey();
        //next ill figureout how to have a counter for keys and coins
        
        GameObject.Find("MasterLogic").GetComponent<Counter>().count++;
    }
    public IEnumerator RemoveKey()
    {
        yield return new WaitForSeconds(5);
        Object.DestroyImmediate(poof, true);
        //print("keyPoof removed!");
    }

}