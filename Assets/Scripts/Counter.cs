using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**This is built from the Project 3 MazeCounter.cs file
 * This is designed to track each artifact that obtained to 
 * better ensure the player has visited each exhibit.
 * 
 * Scene - Artifact:
 * GameIndustry - A Blue Key
 * MovieIndustry - A Movie Reel
 * VR/AR Cad - A Blueprint
 * AR Tech Manuals - An AR headset or a book
 * Medical/Technical Training - A medical device
 * 
 * 27 JUN 2017 - Mike Boyer
 **/

public class ArtifactCounter : MonoBehaviour
{
    public int keyCount = 0;
    public int blueprintCount = 0;
    public int reelCount = 0;
    public int techManCount = 0;
    public int medDeviceCount = 0;
    
    //Return the total number of visitors
    public int GetTotalVisted(int keyCount, int blueprintCount, int reelCount, int techmanCount, int medDeviceCount)
    {
        int totalVisitedCounter = keyCount + blueprintCount + reelCount + techManCount + medDeviceCount;
        return totalVisitedCounter;
}
    
}
  