﻿//Increased Terrain Distance Mod for Daggerfall Tools For Unity
//http://www.reddit.com/r/dftfu
//http://www.dfworkshop.net/
//Author: Michael Rauter (a.k.a. Nystul)
//License: MIT License (http://www.opensource.org/licenses/mit-license.php)

using UnityEngine;
using DaggerfallWorkshop.Game;

namespace ProjectIncreasedTerrainDistance
{
    public class CloneCameraPositionFromMainCamera : MonoBehaviour
    {
        void LateUpdate()
        {
            this.transform.position = Camera.main.transform.position;
        }

    }
}