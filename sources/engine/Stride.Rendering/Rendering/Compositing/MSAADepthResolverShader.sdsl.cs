﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering.Compositing
{
    internal static partial class MSAADepthResolverShaderKeys
    {
        public static readonly ValueParameterKey<Vector4> SvPosUnpack = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Vector2> TextureSizeLess1 = ParameterKeys.NewValue<Vector2>();
        public static readonly ObjectParameterKey<Texture> InputTexture = ParameterKeys.NewObject<Texture>();
    }
}
