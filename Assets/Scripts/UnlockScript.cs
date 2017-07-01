using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScript : MonoBehaviour {
    public bool collectionTrue;

    public bool ArtifactCollected()
    {
        collectionTrue = true;

        return collectionTrue;
    }
    
    
}
