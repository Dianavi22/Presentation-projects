using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LauncherManager : MonoBehaviour
{

    public void LaunchBuild(string pathToOtherBuild)
    {
        if (!string.IsNullOrEmpty(pathToOtherBuild))
        {
            print("HERE");
            Process.Start(pathToOtherBuild);
        }
    }
}
