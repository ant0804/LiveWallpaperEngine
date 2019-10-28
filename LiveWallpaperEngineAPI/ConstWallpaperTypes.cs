﻿using LiveWallpaperEngineAPI.Models;
using System.Collections.Generic;

namespace LiveWallpaperEngineAPI
{
    public static class ConstWallpaperTypes
    {
        public static Dictionary<WallpaperType, string[]> DefinedType = new Dictionary<WallpaperType, string[]>()
        {
            { WallpaperType.Exe,new string[]{".exe" }},
            { WallpaperType.Video,new string[]{".mp4", ".flv", ".blv", ".avi" }},
            { WallpaperType.Image,new string[]{".jpg", ".png", ".gif", ".jpeg", ".bmp" }},
            { WallpaperType.Web,new string[]{".html", ".htm" }},
        };
    }
}
