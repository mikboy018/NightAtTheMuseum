using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoviePlayerControl : MonoBehaviour {
    public MoviePlayerSample moviePlayerSample;
    public Text playButtonText;
    public string[] playButtonStrings = new string[2];
    
    public void Start()
    {
        SetPlayButtonText(false);
    }

    // Invert play/pause state
    public void TogglePaused()
    {
        if (GameObject.Find("SceneLogic").GetComponent<UnlockScript>().collectionTrue == true)
        {
            bool newPauseState = !moviePlayerSample.videoPaused;
            moviePlayerSample.SetPaused(newPauseState);
            SetPlayButtonText(newPauseState);
        }
        else
        {
            Debug.Log("Find the key first!");
        }
    }

    void SetPlayButtonText(bool state)
    {
        playButtonText.text = (state) ? playButtonStrings[0] : playButtonStrings[1];
    }

    public void Rewind()
    {
        moviePlayerSample.Rewind();
    }

}
