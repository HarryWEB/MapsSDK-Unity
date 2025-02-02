﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using UnityEngine;
using Microsoft.Geospatial;
using Microsoft.Maps.Unity;

public class SettingsController : MonoBehaviour
{
    public MapRenderer map;

    public void ModelsToggleHandler(bool toggle)
    {
        map.MapTerrainType = toggle ? MapTerrainType.Default : MapTerrainType.Elevated;
    }

    public void MapShapeHandler(int shape)
    {
        if (shape == 0)
        {
            map.MapShape = MapShape.Block;
        }
        else
        {
            map.MapShape = MapShape.Cylinder;
        }
    }

    public void AnimateToPlace(string location)
    {
        if (location == "Berlin City Center Tower")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(52.52112194306517, 13.409395862843912), 16.5f));
        }
        else if (location == "Brandenburg Gate")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(52.51639631117365, 13.377710633040955), 17.0f));
        }
        else if (location == "British Embassy Berlin")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(52.51565325952461, 13.381043456588655), 18.0f));
        }
        else if (location == "Wilhelm")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(52.51467712304321, 13.382066944437257), 18.0f));
        }
        else if (location == "Space Needle")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(47.62051, -122.349303), 17.5f));
        }
        else if (location == "NYC")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(40.708707, -74.010632), 15.0f));
        }
        else if (location == "Golden Gate")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(37.81869, -122.4787177), 14.5f));
        }
        else if (location == "Colosseum")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(41.890153, 12.492332), 17.5f));
        }
        else if (location == "Atomium")
        {
            map.SetMapScene(new MapSceneOfLocationAndZoomLevel(new LatLon(50.894928, 4.341533), 18.0f));
        }
    }
}