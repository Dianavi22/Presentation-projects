using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LauncherManager : MonoBehaviour
{
    public string pathToOtherBuild; 

    public void LaunchBuild()
    {
        if (!string.IsNullOrEmpty(pathToOtherBuild))
        {
            Process.Start(pathToOtherBuild);
        }
    }
}
