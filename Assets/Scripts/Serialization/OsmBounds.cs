﻿using System.Xml;
using UnityEngine;

class OsmBounds : BaseOsm
{
    public float MinLat { get; private set; }
    public float MaxLat { get; private set; }
    public float MinLon { get; private set; }
    public float MaxLon { get; private set; }
    public Vector3 Center { get; private set; }
    

    public OsmBounds(XmlNode node)
    {
        MinLat = GetAttribute<float>("minLat", node.Attributes);
        MaxLat = GetAttribute<float>("maxLat", node.Attributes);
        MaxLon = GetAttribute<float>("minLon", node.Attributes);
        MaxLon = GetAttribute<float>("maxLon", node.Attributes);

        float x = (float)((MercatorProjection.lonToX(MaxLon) + MercatorProjection.lonToX(MinLon)) / 2);
        float y = (float)((MercatorProjection.latToY(MaxLat) + MercatorProjection.latToY(MinLat)) / 2);

        Center = new Vector3(x, 0, y);
    }        


}
