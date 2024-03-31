﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RouteManager.v2.dataStructures
{
    public class StationMapData
    {
        public Vector3 Pos0 { get; set; }
        public Vector3 Pos1 { get; set; }
        public Vector3 Center { get; set; }
        public float Length { get; set; }

        //branch this station belongs to
        public string Branch {  get; set; } 

        //branches connected to this station
        public List<string> Branches { get; set; }

        //Point coordinates of the referenced station in the 3d map space.
        public StationMapData(float x0, float y0, float z0, float x1, float y1, float z1, float xc, float yc, float zc, float len)
        {
            Pos0 = new Vector3(x0, y0, z0);
            Pos1 = new Vector3(x1, y1, z1);
            Center = new Vector3(xc, yc, zc);
            Length = len;
            Branches = new List<string>();
        }
    }
}
