﻿using OpenTK;
using Sledge.DataStructures.Geometric;
using Sledge.Rendering.Scenes.Renderables;

namespace Sledge.Rendering.Cameras
{
    public abstract class Camera
    {
        public CameraFlags Flags { get; set; }
        public CameraRenderOptions RenderOptions { get; set; }
        public abstract Coordinate EyeLocation { get; }
        public abstract Matrix4 GetCameraMatrix();
        public abstract Matrix4 GetViewportMatrix(int width, int height);
    }
}