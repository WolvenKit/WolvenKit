using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.SharpDX.Core.Core.Components;
using HelixToolkit.SharpDX.Core.Model;
using HelixToolkit.SharpDX.Core.Render;
using HelixToolkit.SharpDX.Core.Shaders;
using HelixToolkit.SharpDX.Core.Utilities;
using HelixToolkit.Wpf.SharpDX;

namespace WolvenKit.App.ViewModels.Documents.Multilayer;

/// <summary>
/// Contents of the HLSL <c>cbMultilayer</c> buffer: header (6 vectors) + 20 layers × 9 vectors.
/// Layout is documented in the shader source.
/// </summary>
[InlineArray(FloatCount)]
public struct MultilayerConstants
{
    public const int HeaderVectors = 6;
    public const int FloatCount = (HeaderVectors + (MultilayerShader.MaxLayers * MultilayerShader.VectorsPerLayer)) * 4;

    /// <summary>Float index of the debug vector (header vector 2).</summary>
    public const int DebugOffset = 8;

    /// <summary>Float index of the decal overlay slot A (header vector 3): pool indices of colour, normal, roughness-metalness, facing.</summary>
    public const int OverlayOffset = 12;

    /// <summary>Float index of the decal overlay slot B (header vector 4): the other side of shared UV.</summary>
    public const int OverlayBOffset = 16;

    /// <summary>Float index of the overlay flags (header vector 5): x = normals as RNM.</summary>
    public const int OverlayFlagsOffset = 20;
    public const int SizeInBytes = FloatCount * sizeof(float);

    private float _element0;
}

/// <summary>
/// Contents of the HLSL <c>cbSurfaceExtra</c> buffer: per-material extras of the plain PBR passes
/// (glass). Uploaded for every plain draw, so no material sees another one's values.
/// </summary>
[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct SurfaceExtraConstants
{
    public const int SizeInBytes = 3 * 16;

    /// <summary>rgb: specular tint, w: 1 = use it.</summary>
    public SharpDX.Vector4 SpecularTint;

    /// <summary>x: edge tint exponent (0 = off), y: vertex colour tint amount, z: unused, w: 1 = clay view.</summary>
    public SharpDX.Vector4 Glass;

    /// <summary>x: 1 = back faces shaded as glass backs, y: back reflection power, z: back opacity, w: unused.</summary>
    public SharpDX.Vector4 GlassBack;
}

/// <summary>Per-material glass extras (see <see cref="SurfaceExtraConstants"/>).</summary>
public sealed record SurfaceExtras(
    SharpDX.Vector3? SpecularTint = null,
    float EdgeTintExponent = 0f,
    float VertexTint = 0f,
    bool GlassBackFaces = false,
    float BackReflectionPower = 1f,
    float BackOpacity = 0f)
{
    public SurfaceExtraConstants ToConstants() => new()
    {
        SpecularTint = SpecularTint is { } t ? new SharpDX.Vector4(t, 1f) : new SharpDX.Vector4(1f, 1f, 1f, 0f),
        Glass = new SharpDX.Vector4(EdgeTintExponent, VertexTint, 0f, 0f),
        GlassBack = new SharpDX.Vector4(GlassBackFaces ? 1f : 0f, BackReflectionPower, BackOpacity, 0f),
    };
}

/// <summary>Everything one multilayer material needs on the GPU.</summary>
public sealed class MultilayerGpuData
{
    public MultilayerGpuData(TextureModel[] textures, MultilayerConstants constants, IReadOnlyList<string>? layerLabels = null)
    {
        Textures = textures;
        Constants = constants;
        LayerLabels = layerLabels ?? Array.Empty<string>();
    }

    /// <summary>One label per shader layer (index = shader layer), for the debug layer picker.</summary>
    public IReadOnlyList<string> LayerLabels { get; }

    /// <summary>Texture pool, bound to t64.. in this order (indices are stored in the constants).</summary>
    public TextureModel[] Textures { get; }

    public MultilayerConstants Constants { get; }

    /// <summary>
    /// The same material with a decal overlay: the overlay maps are added to the texture pool
    /// and their indices written to the overlay vectors. Null when the pool would be too large.
    /// </summary>
    public MultilayerGpuData? WithOverlay(MultilayerOverlaySlot a, MultilayerOverlaySlot? b, bool rnm)
    {
        var textures = new List<TextureModel>(Textures);
        float Add(TextureModel? texture)
        {
            if (texture == null)
            {
                return -1;
            }

            textures.Add(texture);
            return textures.Count - 1;
        }

        var constants = Constants;
        void Slot(int offset, MultilayerOverlaySlot? slot)
        {
            constants[offset] = Add(slot?.Color);
            constants[offset + 1] = Add(slot?.Normal);
            constants[offset + 2] = Add(slot?.RoughMetal);
            constants[offset + 3] = Add(slot?.Facing);
        }

        Slot(MultilayerConstants.OverlayOffset, a);
        Slot(MultilayerConstants.OverlayBOffset, b);
        constants[MultilayerConstants.OverlayFlagsOffset] = rnm ? 1 : 0;
        return textures.Count > MultilayerShader.PoolSize
            ? null
            : new MultilayerGpuData(textures.ToArray(), constants, LayerLabels);
    }
}

/// <summary>
/// PBR material used for every preview mesh. With <see cref="MultilayerData"/> its albedo /
/// roughness / metalness / normal come from the multilayer shader; without it, it renders its
/// maps like Helix's PBR but with a smooth tangent frame (no visible triangles).
/// It is still a <see cref="PBRMaterial"/>, so every existing code path keeps working; lighting,
/// shadows and factors (AlbedoColor, RoughnessFactor, MetallicFactor) behave as for the baked maps.
/// </summary>
public class MultilayerPBRMaterial : PBRMaterial
{
    public MultilayerGpuData? MultilayerData
    {
        get => ((MultilayerPBRMaterialCore)Core).Data;
        set => ((MultilayerPBRMaterialCore)Core).Data = value;
    }

    /// <summary>Debug view of this material only; 0 = shaded.</summary>
    public int DebugMode
    {
        get => ((MultilayerPBRMaterialCore)Core).DebugMode;
        set => ((MultilayerPBRMaterialCore)Core).DebugMode = value;
    }

    /// <summary>Debug: shader layer shown alone by the solo views; -1 = all layers.</summary>
    public int SoloLayer
    {
        get => ((MultilayerPBRMaterialCore)Core).SoloLayer;
        set => ((MultilayerPBRMaterialCore)Core).SoloLayer = value;
    }

    /// <summary>Glass extras of the plain passes; null = none.</summary>
    public SurfaceExtras? Extras
    {
        get => ((MultilayerPBRMaterialCore)Core).Extras;
        set => ((MultilayerPBRMaterialCore)Core).Extras = value;
    }

    /// <summary>Not drawn as clay in the clay view (sector previews).</summary>
    public bool ClayExempt
    {
        get => ((MultilayerPBRMaterialCore)Core).ClayExempt;
        set => ((MultilayerPBRMaterialCore)Core).ClayExempt = value;
    }

    /// <summary>Redraw without touching the GPU data (debug view switches).</summary>
    public void RequestRedraw() => ((MultilayerPBRMaterialCore)Core).RedrawToken++;

    protected override MaterialCore OnCreateCore()
    {
        // Same property copy as PBRMaterial.OnCreateCore (HelixToolkit 2.26), into our core type.
        return new MultilayerPBRMaterialCore()
        {
            Name = Name,
            AlbedoColor = AlbedoColor,
            MetallicFactor = (float)MetallicFactor,
            RoughnessFactor = (float)RoughnessFactor,
            AmbientOcclusionFactor = (float)AmbientOcclusionFactor,
            ReflectanceFactor = (float)ReflectanceFactor,
            ClearCoatStrength = (float)ClearCoatStrength,
            ClearCoatRoughness = (float)ClearCoatRoughness,

            AlbedoMap = AlbedoMap,
            NormalMap = NormalMap,
            EmissiveMap = EmissiveMap,
            RoughnessMetallicMap = RoughnessMetallicMap,
            AmbientOcculsionMap = AmbientOcculsionMap,
            IrradianceMap = IrradianceMap,
            DisplacementMap = DisplacementMap,
            SurfaceMapSampler = SurfaceMapSampler,
            IBLSampler = IBLSampler,
            DisplacementMapSampler = DisplacementMapSampler,

            RenderAlbedoMap = RenderAlbedoMap,
            RenderDisplacementMap = RenderDisplacementMap,
            RenderEmissiveMap = RenderEmissiveMap,
            RenderEnvironmentMap = RenderEnvironmentMap,
            RenderIrradianceMap = RenderIrradianceMap,
            RenderNormalMap = RenderNormalMap,
            RenderRoughnessMetallicMap = RenderRoughnessMetallicMap,
            RenderAmbientOcclusionMap = RenderAmbientOcclusionMap,
            RenderShadowMap = RenderShadowMap,
            EnableAutoTangent = EnableAutoTangent,
            DisplacementMapScaleMask = DisplacementMapScaleMask,
            UVTransform = UVTransform,

            EnableTessellation = EnableTessellation,
            MaxDistanceTessellationFactor = (float)MaxDistanceTessellationFactor,
            MinDistanceTessellationFactor = (float)MinDistanceTessellationFactor,
            MaxTessellationDistance = (float)MaxTessellationDistance,
            MinTessellationDistance = (float)MinTessellationDistance,
            EnableFlatShading = EnableFlatShading,
            VertexColorBlendingFactor = (float)VertexColorBlendingFactor,
        };
    }

    // Freezable.Clone() creates the instance here, then copies the dependency properties.
    protected override Freezable CreateInstanceCore() => new MultilayerPBRMaterial { MultilayerData = MultilayerData, Extras = Extras, ClayExempt = ClayExempt };

    public override PBRMaterial CloneMaterial()
    {
        var clone = new MultilayerPBRMaterial();
        CopyTo(clone);
        clone.MultilayerData = MultilayerData;
        clone.Extras = Extras;
        clone.ClayExempt = ClayExempt;
        return clone;
    }

    private void CopyTo(PBRMaterial m)
    {
        m.Name = Name;
        m.AlbedoColor = AlbedoColor;
        m.MetallicFactor = MetallicFactor;
        m.RoughnessFactor = RoughnessFactor;
        m.AmbientOcclusionFactor = AmbientOcclusionFactor;
        m.ReflectanceFactor = ReflectanceFactor;
        m.ClearCoatStrength = ClearCoatStrength;
        m.ClearCoatRoughness = ClearCoatRoughness;
        m.AlbedoMap = AlbedoMap;
        m.NormalMap = NormalMap;
        m.EmissiveMap = EmissiveMap;
        m.RoughnessMetallicMap = RoughnessMetallicMap;
        m.AmbientOcculsionMap = AmbientOcculsionMap;
        m.IrradianceMap = IrradianceMap;
        m.DisplacementMap = DisplacementMap;
        m.SurfaceMapSampler = SurfaceMapSampler;
        m.IBLSampler = IBLSampler;
        m.DisplacementMapSampler = DisplacementMapSampler;
        m.RenderAlbedoMap = RenderAlbedoMap;
        m.RenderDisplacementMap = RenderDisplacementMap;
        m.RenderEmissiveMap = RenderEmissiveMap;
        m.RenderEnvironmentMap = RenderEnvironmentMap;
        m.RenderIrradianceMap = RenderIrradianceMap;
        m.RenderNormalMap = RenderNormalMap;
        m.RenderRoughnessMetallicMap = RenderRoughnessMetallicMap;
        m.RenderAmbientOcclusionMap = RenderAmbientOcclusionMap;
        m.RenderShadowMap = RenderShadowMap;
        m.EnableAutoTangent = EnableAutoTangent;
        m.DisplacementMapScaleMask = DisplacementMapScaleMask;
        m.UVTransform = UVTransform;
        m.EnableTessellation = EnableTessellation;
        m.MaxDistanceTessellationFactor = MaxDistanceTessellationFactor;
        m.MinDistanceTessellationFactor = MinDistanceTessellationFactor;
        m.MaxTessellationDistance = MaxTessellationDistance;
        m.MinTessellationDistance = MinTessellationDistance;
        m.EnableFlatShading = EnableFlatShading;
        m.VertexColorBlendingFactor = VertexColorBlendingFactor;
    }
}

public sealed class MultilayerPBRMaterialCore : PBRMaterialCore
{
    private MultilayerGpuData? _data;

    public MultilayerGpuData? Data
    {
        get => _data;
        set => Set(ref _data, value);
    }

    private int _debugMode;

    /// <summary>Debug view of this material (see <see cref="MultilayerShader.DebugMode"/>); 0 = shaded.</summary>
    public int DebugMode
    {
        get => _debugMode;
        set => Set(ref _debugMode, value);
    }

    private int _soloLayer = -1;

    /// <summary>Debug: shader layer shown alone by the solo views of this material; -1 = all.</summary>
    public int SoloLayer
    {
        get => _soloLayer;
        set => Set(ref _soloLayer, value);
    }

    private SurfaceExtras? _extras;

    /// <summary>Glass extras of the plain passes; null = none.</summary>
    public SurfaceExtras? Extras
    {
        get => _extras;
        set => Set(ref _extras, value);
    }

    /// <summary>Not drawn as clay in the clay view (sector previews).</summary>
    public bool ClayExempt { get; set; }

    private int _redrawToken;

    /// <summary>Any change raises PropertyChanged, which makes the viewport redraw (debug view switches).</summary>
    public int RedrawToken
    {
        get => _redrawToken;
        set => Set(ref _redrawToken, value);
    }

    public override MaterialVariable CreateMaterialVariables(IEffectsManager manager, IRenderTechnique technique)
        => new MultilayerPBRMaterialVariable(manager, technique, this);
}

/// <summary>
/// Helix's PBR variable plus the multilayer pass: when the material has data and the technique
/// has the pass (only the plain mesh technique gets it), opaque draws use the multilayer shader
/// and this variable binds its texture pool, sampler and constant buffer. Everything else
/// (shadows, depth, wireframe, transparent/OIT, techniques without the pass) stays standard PBR.
/// </summary>
public sealed class MultilayerPBRMaterialVariable : PBRMaterialVariable
{
    private readonly ITextureResourceManager _textureManager;
    private readonly ShaderPass _multilayerPass;
    private readonly ShaderPass _smoothPbrPass;
    private readonly ShaderPass _smoothPbrOitPass;
    private readonly ShaderPass _smoothPbrOitDpPass;
    private readonly ShaderPass _wireframeAlphaPass;
    private readonly ConstantBufferComponent _constantBuffer;
    private readonly ConstantBufferComponent _extraBuffer;
    private SurfaceExtraConstants _extraConstants;
    private SamplerStateProxy? _sampler;
    private ShaderResourceViewProxy?[] _views = Array.Empty<ShaderResourceViewProxy?>();
    private MultilayerConstants _constants;
    private readonly MultilayerPBRMaterialCore _core;
    private bool _hasData;

    public MultilayerPBRMaterialVariable(IEffectsManager manager, IRenderTechnique technique, MultilayerPBRMaterialCore core)
        : base(manager, technique, core)
    {
        _core = core;
        _textureManager = manager.MaterialTextureManager;
        _multilayerPass = technique[MultilayerShader.PassName];
        _smoothPbrPass = technique[MultilayerShader.SmoothPbrPassName];
        _smoothPbrOitPass = technique[MultilayerShader.SmoothPbrOitPassName];
        _smoothPbrOitDpPass = technique[MultilayerShader.SmoothPbrOitDpPassName];
        _wireframeAlphaPass = technique[MultilayerShader.WireframeAlphaPassName];
        _sampler = manager.StateManager.Register(MultilayerShader.SamplerDescription);
        _constantBuffer = new ConstantBufferComponent(
            new ConstantBufferDescription(MultilayerShader.ConstantBufferName, MultilayerConstants.SizeInBytes));
        _constantBuffer.Attach(technique);
        _extraBuffer = new ConstantBufferComponent(
            new ConstantBufferDescription(MultilayerShader.ExtraConstantBufferName, SurfaceExtraConstants.SizeInBytes));
        _extraBuffer.Attach(technique);
    }

    private bool CanUseMultilayerPass => _hasData && !_multilayerPass.IsNULL;

    protected override void OnInitialPropertyBindings()
    {
        base.OnInitialPropertyBindings();
        AddPropertyBinding(nameof(MultilayerPBRMaterialCore.Data), UpdateData);
    }

    private void UpdateData()
    {
        ReleaseViews();

        var data = _core.Data;
        if (data == null || data.Textures.Length > MultilayerShader.PoolSize)
        {
            _hasData = false;
            return;
        }

        _views = new ShaderResourceViewProxy?[data.Textures.Length];
        for (var i = 0; i < data.Textures.Length; i++)
        {
            _views[i] = _textureManager.Register(data.Textures[i]);
        }

        _constants = data.Constants;
        _hasData = true;
    }

    private void ReleaseViews()
    {
        for (var i = 0; i < _views.Length; i++)
        {
            RemoveAndDispose(ref _views[i]);
        }

        _views = Array.Empty<ShaderResourceViewProxy?>();
    }

    public override ShaderPass GetPass(RenderType renderType, RenderContext context)
    {
        if (renderType != RenderType.Transparent)
        {
            if (CanUseMultilayerPass)
            {
                return _multilayerPass;
            }

            // Baked / plain maps: same PBR, smooth tangent frame.
            if (!_smoothPbrPass.IsNULL && !EnableTessellation)
            {
                return _smoothPbrPass;
            }
        }
        else if (!EnableTessellation)
        {
            // Transparent: Helix's OIT stages with the same shading (smooth tangent frame,
            // baked-normal Y). The depth-peeling init stage stays Helix's (depth only).
            switch (context.OITRenderStage)
            {
                case OITRenderStage.SinglePassWeighted when !_smoothPbrOitPass.IsNULL:
                    return _smoothPbrOitPass;
                case OITRenderStage.DepthPeeling when !_smoothPbrOitDpPass.IsNULL:
                    return _smoothPbrOitDpPass;
            }
        }

        return base.GetPass(renderType, context);
    }

    /// <summary>
    /// Every draw of these passes writes the buffer, so none reads the previous material's
    /// extras; the clay view rides along in it.
    /// </summary>
    private void UploadExtras(DeviceContextProxy deviceContext)
    {
        _extraConstants = _core.Extras?.ToConstants() ?? new SurfaceExtras().ToConstants();
        _extraConstants.Glass.W = MultilayerShader.ClayView && !_core.ClayExempt ? 1f : 0f;
        _extraBuffer.Upload(deviceContext, ref _extraConstants);
    }

    /// <summary>Opaque meshes draw their wireframe blended (see the pass in MultilayerEffectsManager).</summary>
    public override ShaderPass GetWireframePass(RenderType renderType, RenderContext context) =>
        renderType != RenderType.Transparent && !_wireframeAlphaPass.IsNULL
            ? _wireframeAlphaPass
            : base.GetWireframePass(renderType, context);

    public override bool BindMaterialResources(RenderContext context, DeviceContextProxy deviceContext, ShaderPass shaderPass)
    {
        // Shadow / SSAO / environment bindings: identical registers in both pixel shaders.
        var result = base.BindMaterialResources(context, deviceContext, shaderPass);

        if (CanUseMultilayerPass && ReferenceEquals(shaderPass, _multilayerPass) && !shaderPass.PixelShader.IsNULL)
        {
            var ps = shaderPass.PixelShader;
            for (var i = 0; i < _views.Length; i++)
            {
                ps.BindTexture(deviceContext, MultilayerShader.TextureSlot + i, _views[i]);
            }

            ps.BindSampler(deviceContext, MultilayerShader.SamplerSlot, _sampler);
            _constants[MultilayerConstants.DebugOffset] = _core.DebugMode;
            _constants[MultilayerConstants.DebugOffset + 1] = _core.SoloLayer;
            _constantBuffer.Upload(deviceContext, ref _constants);
            UploadExtras(deviceContext);
        }
        else if (ReferenceEquals(shaderPass, _smoothPbrPass) || ReferenceEquals(shaderPass, _smoothPbrOitPass) ||
                 ReferenceEquals(shaderPass, _smoothPbrOitDpPass))
        {
            UploadExtras(deviceContext);
        }

        return result;
    }

    protected override void OnDispose(bool disposeManagedResources)
    {
        ReleaseViews();
        RemoveAndDispose(ref _sampler);
        _constantBuffer.Detach();
        _constantBuffer.Dispose();
        _extraBuffer.Detach();
        _extraBuffer.Dispose();
        base.OnDispose(disposeManagedResources);
    }
}

/// <summary>
/// Default Helix effects plus the multilayer pass on the mesh technique.
/// If the shader does not compile, the pass is simply absent and materials fall back to PBR.
/// </summary>
public class MultilayerEffectsManager : DefaultEffectsManager
{
    public MultilayerEffectsManager()
    {
        var bytecode = MultilayerShader.GetBytecode();
        if (bytecode == null)
        {
            return;
        }

        var mesh = GetTechnique(DefaultRenderTechniqueNames.Mesh);
        mesh.AddPass(CreatePass(MultilayerShader.PassName,
            new ShaderDescription(nameof(MultilayerShader), ShaderStage.Pixel, new ShaderReflector(), bytecode)));

        var pbr = MultilayerShader.GetPbrBytecode();
        if (pbr != null)
        {
            mesh.AddPass(CreatePass(MultilayerShader.SmoothPbrPassName,
                new ShaderDescription(MultilayerShader.SmoothPbrPassName, ShaderStage.Pixel, new ShaderReflector(), pbr)));
        }

        // Same blend / depth states as Helix's PBROITPass and PBROITDPPass.
        if (MultilayerShader.GetPbrOitBytecode() is { } oit)
        {
            mesh.AddPass(CreatePass(MultilayerShader.SmoothPbrOitPassName,
                new ShaderDescription(MultilayerShader.SmoothPbrOitPassName, ShaderStage.Pixel, new ShaderReflector(), oit),
                DefaultBlendStateDescriptions.BSOITBlend, DefaultDepthStencilDescriptions.DSSLessNoWrite));
        }

        // Helix's wireframe pass writes the edge colour without blending; this copy blends it,
        // so the colour's alpha (the preview's wireframe opacity) shows the surface through.
        mesh.AddPass(new ShaderPassDescription(MultilayerShader.WireframeAlphaPassName)
        {
            InputLayoutDescription = new InputLayoutDescription(DefaultVSShaderByteCodes.VSMeshDefault, DefaultInputLayout.VSInput),
            ShaderList = new[]
            {
                DefaultVSShaderDescriptions.VSMeshWireframe,
                DefaultPSShaderDescriptions.PSMeshWireframe,
            },
            BlendStateDescription = DefaultBlendStateDescriptions.BSAlphaBlend,
            DepthStencilStateDescription = DefaultDepthStencilDescriptions.DSSLessEqualNoWrite,
            Topology = global::SharpDX.Direct3D.PrimitiveTopology.TriangleList,
        });

        if (MultilayerShader.GetPbrOitDpBytecode() is { } dp)
        {
            mesh.AddPass(CreatePass(MultilayerShader.SmoothPbrOitDpPassName,
                new ShaderDescription(MultilayerShader.SmoothPbrOitDpPassName, ShaderStage.Pixel, new ShaderReflector(), dp),
                DefaultBlendStateDescriptions.BSOITDP, DefaultDepthStencilDescriptions.DSSLessNoWrite));
        }
    }

    private static ShaderPassDescription CreatePass(string name, ShaderDescription pixelShader) =>
        CreatePass(name, pixelShader, DefaultBlendStateDescriptions.BSAlphaBlend, DefaultDepthStencilDescriptions.DSSDepthLessEqual);

    private static ShaderPassDescription CreatePass(string name, ShaderDescription pixelShader,
        global::SharpDX.Direct3D11.BlendStateDescription blend,
        global::SharpDX.Direct3D11.DepthStencilStateDescription depth) => new(name)
    {
        // A pass added after the technique is built does not inherit the technique's input
        // layout: without this the draw reuses whatever layout was bound last and the vertex
        // attributes (UV first of all) are read from the wrong offsets.
        InputLayoutDescription = new InputLayoutDescription(DefaultVSShaderByteCodes.VSMeshDefault, DefaultInputLayout.VSInput),
        ShaderList = new[]
        {
            DefaultVSShaderDescriptions.VSMeshDefault,
            pixelShader,
        },
        BlendStateDescription = blend,
        DepthStencilStateDescription = depth,
    };
}

/// <summary>One decal overlay slot: colour, normal, roughness-metalness and facing maps (each optional).</summary>
public sealed record MultilayerOverlaySlot(TextureModel? Color, TextureModel? Normal, TextureModel? RoughMetal, TextureModel? Facing)
{
    public bool IsEmpty => Color == null && Normal == null && RoughMetal == null;
}
