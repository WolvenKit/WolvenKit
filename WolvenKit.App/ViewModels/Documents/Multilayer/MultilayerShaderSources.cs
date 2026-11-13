// HLSL sources of the live multilayer preview shader.
//
// The Helix headers (Common, CommonBuffers, DataStructs, psCommon, psMeshPBR) are copies of
// HelixToolkit v2.26.0 (Source/HelixToolkit.Native.ShaderBuilder), MIT License,
// Copyright (c) 2018 Helix Toolkit contributors. They must match the HelixToolkit package
// version: the constant buffer layouts are shared with Helix's own compiled shaders.
// Non-ASCII characters in their comments were replaced with '?'.

namespace WolvenKit.App.ViewModels.Documents.Multilayer;

internal static class MultilayerShaderSources
{
    /// <summary>Multilayer pixel shader; ML_SWITCH_CASES is filled in by <see cref="MultilayerShader"/>.</summary>
    public const string PsMultilayer = """
// CP77 multilayer material, evaluated per pixel (WolvenKit mesh preview).
// Same maths as the C# bake / Blender addon, but every texture is sampled at its own
// resolution with hardware mipmaps, so detail does not depend on the UV size or tiling.
//
// Lighting, normals, shadows and IBL come unchanged from Helix's psMeshPBR.hlsl;
// only the inputs (albedo, roughness, metalness, tangent-space normal) are replaced.

#define MESH
#define PBR
#define CLEARCOAT

#include "psMeshPBR.hlsl"

#ifndef ML_POOL
#define ML_POOL 64
#endif
#define ML_MAX_LAYERS 20
#define ML_VEC_PER_LAYER 9

// Unique textures used by this material. t64..t127 are free in Helix's pixel shaders.
// The depth-peeling pass is compiled with ML_NO_POOL: it needs t100 for Helix's depth buffer.
#ifndef ML_NO_POOL
Texture2D mlTex[ML_POOL] : register(t64);
#endif
SamplerState mlSampler : register(s10);

cbuffer cbMultilayer : register(b11)
{
    // x: layer count, y: GlobalNormal pool index (-1 none), z: GlobalNormalIntensity, w: unused
    float4 mlHeader;
    // GlobalNormalUVScale.xy, GlobalNormalUVBias.xy
    float4 mlGlobalUV;
    // Debug view: x mode (0 shaded, 1 albedo, 2 roughness, 3 metalness, 4 normal, 5 layer coverage,
    // 6 layer mask, 7 layer tiling), y solo layer (-1 = all), z unused, w always 0 (see mlKeepInputs)
    float4 mlDebug;
    // Decal overlay (mesh decals blended on this surface, drawn in its UV space), two slots for
    // texels shared by both sides of a mirrored mesh. Pool index of x colour (sRGB rgb,
    // a = coverage), y normal (baked-PNG encoding, a = coverage), z roughness (g) / metalness (b)
    // (a = coverage), w facing (world normal of the decals *0.5+0.5, a = coverage); -1 none.
    // Without a facing map the slot applies everywhere.
    float4 mlOverlay;
    float4 mlOverlayB;
    // x: 1 = normals blended as RNM.
    float4 mlOverlayFlags;
    // Per layer, ML_VEC_PER_LAYER vectors:
    //  0: colorScale.rgb, opacity
    //  1: matTile, mbTile, offsetU, offsetV
    //  2: mbOffsetU, mbOffsetV, mbContrast, mbNormalStrength
    //  3: roughIn scale, roughIn offset, roughOut scale, roughOut offset
    //  4: metalIn scale, metalIn offset, metalOut scale, metalOut offset
    //  5: normalStrength, constant roughness, constant metalness, colour enabled (0/1)
    //  6: pool index: mask, colour, normal, roughness   (-1 = constant / none)
    //  7: pool index: metalness, microblend; base layer flag; constant mask (used when mask index is -1)
    //  8: constant colour (sRGB) when the colour texture is a solid placeholder; has constant colour
    float4 mlLayers[ML_MAX_LAYERS * ML_VEC_PER_LAYER];
};

// One branch per pool slot: SM5 needs a literal index for a texture array.
// SampleGrad keeps hardware mip selection inside the dynamic layer loop.
float4 mlSample(int idx, float2 uv, float2 dx, float2 dy)
{
#ifndef ML_NO_POOL
    [forcecase] switch (idx)
    {
ML_SWITCH_CASES
    }
#endif
    return float4(0, 0, 0, 0);
}

float mlSrgbToLinear(float x)
{
    x = saturate(x);
    return x <= 0.04045 ? x / 12.92 : pow((x + 0.055) / 1.055, 2.4);
}

float mlLinearToSrgb(float x)
{
    x = saturate(x);
    return x <= 0.0031308 ? 12.92 * x : 1.055 * pow(x, 1.0 / 2.4) - 0.055;
}

float3 mlSrgbToLinear3(float3 c)
{
    return float3(mlSrgbToLinear(c.r), mlSrgbToLinear(c.g), mlSrgbToLinear(c.b));
}

float3 mlLinearToSrgb3(float3 c)
{
    return float3(mlLinearToSrgb(c.r), mlLinearToSrgb(c.g), mlLinearToSrgb(c.b));
}

// Blender mask_mixer: safeC = max(c, 1e-5), burn = mask + mb - 1,
// mixed = lerp(burn, mask, safeC), out = saturate(mixed / safeC)
float mlMaskMixer(float mask, float mbA, float contrast)
{
    float safeC = max(contrast, 1e-5);
    float burn = mask + mbA - 1.0;
    float mixed = burn + (mask - burn) * safeC;
    return saturate(mixed / safeC);
}

// Tiled UV as in the bake / Blender mapping (V measured bottom-up):
// U = u * tile + offU, V = (1 - v) * tile + offV, on the texture as stored in the xbm
// (not flipped). The wrap sampler does the frac().
float2 mlTiled(float2 uv, float tile, float offU, float offV)
{
    return float2(uv.x * tile + offU, (1.0 - uv.y) * tile + offV);
}

struct MLSurface
{
    float3 albedo; // sRGB, as the baked PNG
    float roughness;
    float metallic;
    float3 localNormal; // tangent space, same encoding the baked normal map decodes to
    float topLayer;     // debug: last layer covering the pixel by more than half
    float soloFactor;   // debug: factor of the solo layer
};

MLSurface mlEvaluate(float2 uv)
{
    float2 dx = ddx(uv);
    float2 dy = ddy(uv);

    float3 accColor = float3(0, 0, 0);
    float accRough = 0.5;
    float accMetal = 0.0;
    float2 accNormal = float2(0, 0);

    int layerCount = (int) mlHeader.x;
    int solo = (int) mlDebug.y;
    float topLayer = -1;
    float soloFactor = 0;

    [loop]
    for (int i = 0; i < layerCount; ++i)
    {
        if (solo >= 0 && i != solo)
        {
            continue;
        }

        int b = i * ML_VEC_PER_LAYER;
        float4 v0 = mlLayers[b + 0];
        float4 v1 = mlLayers[b + 1];
        float4 v2 = mlLayers[b + 2];
        float4 v3 = mlLayers[b + 3];
        float4 v4 = mlLayers[b + 4];
        float4 v5 = mlLayers[b + 5];
        float4 v6 = mlLayers[b + 6];
        float4 v7 = mlLayers[b + 7];
        float4 v8 = mlLayers[b + 8];

        int maskIdx = (int) v6.x;
        int colorIdx = (int) v6.y;
        int normalIdx = (int) v6.z;
        int roughIdx = (int) v6.w;
        int metalIdx = (int) v7.x;
        int mbIdx = (int) v7.y;
        bool isBase = v7.z > 0.5;

        float opacity = v0.w;
        float matTile = v1.x;
        float mbTile = v1.y;

        float2 matUV = mlTiled(uv, matTile, v1.z, v1.w);
        float2 mbUV = mlTiled(uv, mbTile, v2.x, v2.y);

        // All samples of a layer go through one mlSample call site (each call site expands
        // to the whole switch): 0 mask, 1 microblend, 2 colour, 3 roughness, 4 metalness, 5 normal.
        int sIdx[6] = { isBase ? -1 : maskIdx, mbIdx, colorIdx, roughIdx, metalIdx, normalIdx };
        float2 sUV[6] = { uv, mbUV, matUV, matUV, matUV, matUV };
        float sScale[6] = { 1.0, mbTile, matTile, matTile, matTile, matTile };
        float baseMask = isBase ? 1.0 : v7.w; // constant mask when the mask is a solid placeholder
        float4 sRes[6] = { baseMask.xxxx, float4(0.5, 0.5, 1, 1), float4(1, 1, 1, 1),
                           float4(0, 0, 0, 0), float4(0, 0, 0, 0), float4(0.5, 0.5, 1, 1) };

        // ---- mask x microblend (mask_mixer) ----
        [loop]
        for (int k = 0; k < 2; ++k)
        {
            if (sIdx[k] >= 0)
            {
                sRes[k] = mlSample(sIdx[k], sUV[k], dx * sScale[k], dy * sScale[k]);
            }
        }

        float mask = sRes[0].r;
        float4 mb = sRes[1];
        float remap = mlMaskMixer(mask, mbIdx >= 0 ? mb.a : 1.0, v2.z);
        float factor = isBase ? 1.0 : saturate(remap * opacity);
        soloFactor = factor;
        if (factor > 0.5)
        {
            topLayer = i;
        }
        if (factor < 0.001)
        {
            continue;
        }

        // Only now (the layer is visible here) sample the template textures.
        [loop]
        for (int t = 2; t < 6; ++t)
        {
            if (sIdx[t] >= 0)
            {
                sRes[t] = mlSample(sIdx[t], sUV[t], dx * sScale[t], dy * sScale[t]);
            }
        }

        // ---- colour (linear, like the addon) ----
        if (v5.w > 0.5)
        {
            float3 src = float3(1, 1, 1);
            if (colorIdx >= 0)
            {
                src = mlSrgbToLinear3(sRes[2].rgb);
            }
            else if (v8.w > 0.5)
            {
                src = mlSrgbToLinear3(v8.rgb);
            }
            src *= v0.rgb;
            accColor = lerp(accColor, src, factor);
        }

        // ---- roughness / metalness: levels In then Out, unclamped until the end ----
        float roughValue = roughIdx >= 0 ? sRes[3].r : v5.y;
        float metalValue = metalIdx >= 0 ? sRes[4].r : v5.z;
        float roughness = (roughValue * v3.x + v3.y) * v3.z + v3.w;
        float metallic = (metalValue * v4.x + v4.y) * v4.z + v4.w;
        accRough = lerp(accRough, roughness, factor);
        accMetal = lerp(accMetal, metallic, factor);

        // ---- normal: template (xy*2-1)*strength + microblend below full mask ----
        float2 layerN = float2(0, 0);
        if (normalIdx >= 0)
        {
            layerN = (sRes[5].rg * 2.0 - 1.0) * v5.x;
        }

        if (mbIdx >= 0 && abs(v2.w) > 1e-6 && remap < 1.0)
        {
            layerN += (mb.rg * 2.0 - 1.0) * v2.w;
        }

        accNormal = lerp(accNormal, layerN, factor);
    }

    // ---- GlobalNormal (addon "Global Normal Decode") ----
    int globalIdx = (int) mlHeader.y;
    if (globalIdx >= 0)
    {
        float2 gUV = float2(uv.x * mlGlobalUV.x + mlGlobalUV.z,
                            (1.0 - uv.y) * mlGlobalUV.y + mlGlobalUV.w);
        float2 g = mlSample(globalIdx, gUV, dx * mlGlobalUV.xy, dy * mlGlobalUV.xy).rg * 2.0 - 1.0;
        float gz = sqrt(max(0.0, 1.0 - dot(g, g)));
        float intensity = mlHeader.z;
        float3 gn = float3(g * intensity, (gz - 1.0) * intensity + 1.0);
        float len = length(gn);
        if (len > 1e-6)
        {
            gn /= len;
        }
        accNormal += gn.xy;
    }

    MLSurface s;
    s.albedo = mlLinearToSrgb3(accColor);
    s.roughness = saturate(accRough);
    s.metallic = saturate(accMetal);
    float nz = sqrt(max(0.0, 1.0 - dot(accNormal, accNormal)));
    // Game textures are DirectX normal maps: +Y points down the image (increasing row), which is
    // the bitangent direction used here (dP/dV with V = image row). No flip. (The baked PNGs flip
    // Y to OpenGL for Blender; pbrMain undoes that.)
    s.localNormal = float3(accNormal.x, accNormal.y, nz);
    s.topLayer = topLayer;
    s.soloFactor = soloFactor;
    return s;
}

// Tangent frame from screen-space derivatives (as Helix's PeturbNormal), but made orthogonal
// to the interpolated vertex normal. Helix's version keeps the per-triangle components of the
// derivative frame, so any non-flat normal map tilts each triangle differently and smooth
// surfaces (car panels) show their triangles at grazing angles.
float3 mlPerturbSmooth(float3 localNormal, float3 position, float3 normal, float2 texCoord)
{
    float3x3 tbn = CalculateTBN(position, normal, texCoord);
    float3 t = tbn[0] - normal * dot(normal, tbn[0]);
    float lt = length(t);
    if (lt < 1e-5)
    {
        return normal;
    }
    t /= lt;
    float3 b = tbn[1] - normal * dot(normal, tbn[1]) - t * dot(t, tbn[1]);
    float lb = length(b);
    // keep the derivative frame's handedness, so the relief does not flip
    b = lb > 1e-5 ? b / lb : cross(normal, t);
    return normalize(localNormal.x * t + localNormal.y * b + localNormal.z * normal);
}

// Interpolated vertex tangent frame (smooth across triangles). Falls back to the
// derivative frame when the mesh has no tangents.
float3 mlPerturbVertex(float3 localNormal, float3 position, float3 normal, float2 texCoord, float3 t1, float3 t2)
{
    float3 t = t1 - normal * dot(normal, t1);
    float lt = length(t);
    if (lt < 1e-4)
    {
        return mlPerturbSmooth(localNormal, position, normal, texCoord);
    }
    t /= lt;
    float3 b = t2 - normal * dot(normal, t2) - t * dot(t, t2);
    float lb = length(b);
    b = lb > 1e-4 ? b / lb : cross(normal, t);
    return normalize(localNormal.x * t + localNormal.y * b + localNormal.z * normal);
}

float3 mlCalcNormal(PSInput input, float3 localNormal)
{
    float3 normal = bRenderFlat ? normalize(cross(ddy(input.wp.xyz), ddx(input.wp.xyz))) : normalize(input.n);
    return bAutoTengent
        ? mlPerturbSmooth(localNormal, input.wp.xyz, normal, input.t)
        : mlPerturbVertex(localNormal, input.wp.xyz, normal, input.t, input.t1, input.t2);
}

// Mesh decals on this surface, as the game blends them into the G-buffer: colour, normal and
// roughness / metalness each by their own coverage. The overlay is drawn in the mesh UV as
// Helix passes it (input.t, wrapped), like the baked maps.
void mlApplyOverlay(inout MLSurface surf, float2 t, float3 worldNormal)
{
    bool hasA = mlOverlay.x >= 0 || mlOverlay.y >= 0 || mlOverlay.z >= 0;
    bool hasB = mlOverlayB.x >= 0 || mlOverlayB.y >= 0 || mlOverlayB.z >= 0;
    if (!hasA && !hasB)
    {
        return;
    }

    float2 dx = ddx(t);
    float2 dy = ddy(t);

    // k 0, 1: facing of slot A, B (decals are one-sided: a slot applies where the surface faces
    // the way its decals faced; the mirrored side shares the texels but faces away);
    // k 2..4: colour, normal, roughness / metalness of the chosen slot. One mlSample call site.
    float4 o[5] = { float4(0, 0, 0, 0), float4(0, 0, 0, 0), float4(0, 0, 0, 0), float4(0.5, 0.5, 1, 0), float4(0, 0, 0, 0) };
    int idxA[3] = { (int) mlOverlay.x, (int) mlOverlay.y, (int) mlOverlay.z };
    int idxB[3] = { (int) mlOverlayB.x, (int) mlOverlayB.y, (int) mlOverlayB.z };
    int slot = -1;

    [loop]
    for (int k = 0; k < 5; ++k)
    {
        int index = -1;
        if (k == 0)
        {
            index = (int) mlOverlay.w;
        }
        else if (k == 1)
        {
            index = (int) mlOverlayB.w;
        }
        else
        {
            if (k == 2)
            {
                // Slot A unless it has a facing map that points elsewhere here; then B the same way.
                bool aFits = hasA && (mlOverlay.w < 0 || (o[0].a > 0 && dot(o[0].xyz * 2.0 - 1.0, worldNormal) > 0.2));
                bool bFits = hasB && (mlOverlayB.w < 0 || (o[1].a > 0 && dot(o[1].xyz * 2.0 - 1.0, worldNormal) > 0.2));
                slot = aFits ? 0 : (bFits ? 1 : -1);
                if (slot < 0)
                {
                    return;
                }
            }

            index = slot == 0 ? idxA[k - 2] : idxB[k - 2];
        }

        if (index >= 0)
        {
            o[k] = mlSample(index, t, dx, dy);
        }
    }

    surf.albedo = lerp(surf.albedo, o[2].rgb, o[2].a);
    surf.roughness = lerp(surf.roughness, o[4].g, o[4].a);
    surf.metallic = lerp(surf.metallic, o[4].b, o[4].a);

    if (o[3].a > 0)
    {
        // Baked-PNG normals are OpenGL (Y up); the surface normal here is DirectX.
        float3 d = o[3].xyz * 2.0 - 1.0;
        d.y = -d.y;
        float3 base = surf.localNormal;
        float3 n = d;
        if (mlOverlayFlags.x > 0.5)
        {
            // Reoriented normal mapping: the decal's relief on top of the surface's.
            float3 tb = base + float3(0, 0, 1);
            float3 u = d * float3(-1, -1, 1);
            n = tb * dot(tb, u) / tb.z - u;
        }

        surf.localNormal = normalize(lerp(base, normalize(n), o[3].a));
    }
}

// The vertex shader is Helix's compiled vsMeshDefault from the installed package. Its output
// layout is read from that bytecode at run time and declared here as MLVSOutput, then copied
// into PSInput, so the interpolators line up even if the package's headers differ from the
// copies embedded with this shader.
ML_VS_OUTPUT

// Same as psMeshPBR main, with the multilayer surface in place of the texture maps.
float4 mlMain(MLVSOutput vsOut) : SV_Target
{
    PSInput input = mlToPSInput(vsOut);
    const float3 V = normalize(input.vEye.xyz);

    // Helix gets the mesh UV as (u, -v); the bake works on image rows v_img = 1 - v = 1 + t.y.
    float2 uvImg = float2(input.t.x, input.t.y + 1.0);
    MLSurface surf = mlEvaluate(uvImg);
    mlApplyOverlay(surf, input.t, normalize(input.n));

    int debugMode = (int) mlDebug.x;
    if (debugMode == 1) return float4(surf.albedo, 1);
    if (debugMode == 2) return float4(surf.roughness.xxx, 1);
    if (debugMode == 3) return float4(surf.metallic.xxx, 1);
    if (debugMode == 4) return float4(surf.localNormal * 0.5 + 0.5, 1);
    if (debugMode == 5)
    {
        if (surf.topLayer < 0) return float4(0, 0, 0, 1);
        // distinct hue per layer index
        float h = frac(surf.topLayer * 0.618034);
        float3 c = saturate(abs(frac(h + float3(0, 2.0 / 3.0, 1.0 / 3.0)) * 6.0 - 3.0) - 1.0);
        return float4(c, 1);
    }
    if (debugMode == 6) return float4(surf.soloFactor.xxx, 1);
    if (debugMode == 7)
    {
        // Tiling of the selected layer (layer 0 without one): frac of its tiled UV as red/green,
        // one square per repeat of its textures.
        int layer = max((int) mlDebug.y, 0);
        float4 v1 = mlLayers[layer * ML_VEC_PER_LAYER + 1];
        return float4(frac(mlTiled(uvImg, v1.x, v1.z, v1.w)), 0, 1);
    }

    float3 N = mlCalcNormal(input, surf.localNormal);

    float4 albedo = float4(input.cDiffuse.xyz * surf.albedo, 1);
    albedo = lerp(albedo, input.c, vertColorBlending);

    // Material factors multiply the maps, as with the baked RM map.
    float3 RMA = float3(ConstantAO, ConstantRoughness * surf.roughness, ConstantMetallic * surf.metallic);
    if (SSAOEnabled)
    {
        float2 quadTex = input.p.xy * vResolution.zw;
        RMA.r *= texSSAOMap.SampleLevel(samplerSurface, quadTex, 0).r;
    }

    float3 color = LightSurface(input.wp, V, N, albedo.rgb, RMA.g, RMA.b, RMA.r, ConstantReflectance, ClearCoat, ClearCoatRoughness);
    float s = 1;
    if (bHasShadowMap)
    {
        if (bRenderShadowMap)
        {
            float d = dot(getLookDir(vLightView), N);
            if (d > 0)
            {
                s = shadowStrength(input.sp);
            }
        }
    }
    color.rgb *= s;
    float3 emissive = vMaterialEmissive.rgb;
    float3 ambient = vLightAmbient.rgb * RMA.r;
    color += emissive + ambient;
    // mlDebug.w is always 0: reading every interpolator keeps the pixel shader's input
    // signature identical to the vertex shader's output (nothing optimized away or repacked).
    color += mlKeepInputs(vsOut) * mlDebug.w;
    return float4(color, albedo.a * input.cDiffuse.a);
}

// Plain PBR (baked / single-texture materials): Helix's psMeshPBR main, with the smooth
// tangent frame above instead of PeturbNormal. Same bindings as Helix's PBR pass.
float4 pbrMain(MLVSOutput vsOut) : SV_Target
{
    PSInput input = mlToPSInput(vsOut);
    const float3 V = normalize(input.vEye.xyz);

    float3 N = bRenderFlat ? normalize(cross(ddy(input.wp.xyz), ddx(input.wp.xyz))) : normalize(input.n);
    if (bHasNormalMap)
    {
        float3 localNormal = BiasX2(texNormalMap.Sample(samplerSurface, input.t).xyz);
        // Baked normal PNGs are OpenGL (Y up, for Blender); the bitangent here points down
        // the image, so back to DirectX.
        localNormal.y = -localNormal.y;
        N = bAutoTengent
            ? mlPerturbSmooth(localNormal, input.wp.xyz, N, input.t)
            : mlPerturbVertex(localNormal, input.wp.xyz, N, input.t, input.t1, input.t2);
    }

    float4 albedo = float4(input.cDiffuse.xyz, 1);
    float3 RMA = float3(ConstantAO, ConstantRoughness, ConstantMetallic);
    if (bHasDiffuseMap)
    {
        albedo *= texDiffuseMap.Sample(samplerSurface, input.t);
    }
    albedo = lerp(albedo, input.c, vertColorBlending);
    if (bHasRMMap)
    {
        RMA.gb *= texRMMap.Sample(samplerSurface, input.t).gb;
    }
    if (bHasAOMap)
    {
        RMA.r *= texAOMap.Sample(samplerSurface, input.t).r;
    }
    else if (SSAOEnabled)
    {
        float2 quadTex = input.p.xy * vResolution.zw;
        RMA.r *= texSSAOMap.SampleLevel(samplerSurface, quadTex, 0).r;
    }
    float3 color = LightSurface(input.wp, V, N, albedo.rgb, RMA.g, RMA.b, RMA.r, ConstantReflectance, ClearCoat, ClearCoatRoughness);
    float s = 1;
    if (bHasShadowMap)
    {
        if (bRenderShadowMap)
        {
            float d = dot(getLookDir(vLightView), N);
            if (d > 0)
            {
                s = shadowStrength(input.sp);
            }
        }
    }
    color.rgb *= s;
    float3 emissive = vMaterialEmissive.rgb;
    if (bHasEmissiveMap)
    {
        emissive *= texEmissiveMap.Sample(samplerSurface, input.t).rgb;
    }
    float3 ambient = vLightAmbient.rgb * RMA.r;
    color += emissive + ambient;
    color += mlKeepInputs(vsOut) * mlDebug.w; // always 0: keeps every interpolator (see mlMain)
    return float4(color, albedo.a * input.cDiffuse.a);
}

// Transparent materials (hair cards, glass, decals): the same PBR as pbrMain, written the way
// Helix's own transparency passes write it, so they get the smooth tangent frame and the
// baked-normal Y fix too.

// Weighted blended OIT (Helix's psMeshPBROIT).
PSOITOutput pbrOIT(MLVSOutput vsOut)
{
    float4 color = pbrMain(vsOut);
    return calculateOIT(color, vsOut.vEye.w, vsOut.p.z);
}

#ifdef ML_NO_POOL
// Depth peeling (Helix's psMeshPBROITDP + psOITDepthPeelingCommon): Helix binds the min/max
// depth of the previous peel at t100.
Texture2D<float2> mlDepthBlender : register(t100);

struct MLDepthPeelOutput
{
    float2 Depths : SV_Target0;
    float4 FrontColor : SV_Target1;
    float4 BackColor : SV_Target2;
};

MLDepthPeelOutput pbrOITDP(MLVSOutput vsOut)
{
    float4 color = pbrMain(vsOut);
    float4 pos = vsOut.p;
    MLDepthPeelOutput o = (MLDepthPeelOutput)0;
    float fragDepth = pos.z;
    o.Depths.xy = mlDepthBlender.Load(int3(pos.xy, 0)).xy;
    float nearestDepth = -o.Depths.x;
    float farthestDepth = o.Depths.y;
    if (fragDepth < nearestDepth || fragDepth > farthestDepth)
    {
        o.Depths.xy = -1.0f; // skip this depth
        return o;
    }
    if (fragDepth > nearestDepth && fragDepth < farthestDepth)
    {
        o.Depths.xy = float2(-fragDepth, fragDepth); // peel again
        return o;
    }
    o.Depths.xy = -1.0f; // on the peeled layer: shade it, do not peel further
    if (fragDepth == nearestDepth)
    {
        color.rgb *= color.a;
        o.FrontColor = color;
    }
    else
    {
        o.BackColor = color;
    }
    return o;
}
#endif
""";

    /// <summary>Helix headers by file name (include paths are matched by file name only).</summary>
    public static readonly System.Collections.Generic.IReadOnlyDictionary<string, string> Headers =
        new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
        {
            ["Common.hlsl"] = CommonSource,
            ["CommonBuffers.hlsl"] = CommonBuffersSource,
            ["DataStructs.hlsl"] = DataStructsSource,
            ["psCommon.hlsl"] = psCommonSource,
            ["psMeshPBR.hlsl"] = psMeshPBRSource,
        };

    private const string CommonSource = """
#ifndef COMMON_HLSL
#define COMMON_HLSL
#include"CommonBuffers.hlsl"

#pragma pack_matrix( row_major )


//--------------------------------------------------------------------------------------
// GLOBAL FUNCTIONS
//--------------------------------------------------------------------------------------

//--------------------------------------------------------------------------------------
// From projection frame to window pixel pos.
//--------------------------------------------------------------------------------------
float2 projToWindow(in float4 pos)
{
    return float2(vViewport.x * 0.5 * (1.0 + (pos.x / pos.w)),
                  vViewport.y * 0.5 * (1.0 - (pos.y / pos.w)));
}

//--------------------------------------------------------------------------------------
// From window pixel pos to projection frame at the specified z (view frame). 
//--------------------------------------------------------------------------------------
float4 windowToProj(in float2 pos, in float z, in float w)
{
    return float4(((pos.x * 2.0 * vViewport.z) - 1.0) * w,
                  ((pos.y * 2.0 * vViewport.w) - 1.0) * -w,
                  z, w);
}

//--------------------------------------------------------------------------------------
// From window pixel pos to normalized device coordinates.
//--------------------------------------------------------------------------------------
float2 windowToNdc(in float2 pos)
{
    return float2((pos.x * vViewport.z) * 2.0, (pos.y * vViewport.w) * 2.0);
}

float whengt(float l, float cmp)
{
    return max(sign(l - cmp), 0.0);
}

float whenlt(float l, float cmp)
{
    return max(sign(cmp - l), 0.0);
}

float whenge(float l, float cmp)
{
    return 1.0 - whenlt(l, cmp);
}

float whenle(float l, float cmp)
{
    return 1.0 - whengt(l, cmp);
}

float when_eq(float x, float y)
{
    return 1.0 - abs(sign(x - y));
}

float when_neq(float x, float y)
{
    return abs(sign(x - y));
}

float3 whengt(float3 l, float3 cmp)
{
    return max(sign(l - cmp), 0.0);
}

float3 whenlt(float3 l, float3 cmp)
{
    return max(sign(cmp - l), 0.0);
}

float3 whenge(float3 l, float3 cmp)
{
    return 1.0 - whenlt(l, cmp);
}

float3 when_neq(float3 x, float3 y)
{
    return abs(sign(x - y));
}

float3 whenle(float3 l, float3 cmp)
{
    return 1.0 - whengt(l, cmp);
}

float3 when_eq(float3 x, float3 y)
{
    return 1.0 - abs(sign(x - y));
}

float3 and(float3 a, float3 b)
{
    return a * b;
}

float3 or(float3 a, float3 b)
{
    return min(a + b, 1.0);
}

float3 xor(float3 a, float3 b)
{
    return (a + b) % 2.0;
}

float3 not(float3 a)
{
    return 1.0 - a;
}

float4 whengt(float4 l, float4 cmp)
{
    return max(sign(l - cmp), 0.0);
}

float4 whenlt(float4 l, float4 cmp)
{
    return max(sign(cmp - l), 0.0);
}

float4 whenge(float4 l, float4 cmp)
{
    return 1.0 - whenlt(l, cmp);
}

float4 when_neq(float4 x, float4 y)
{
    return abs(sign(x - y));
}

float4 whenle(float4 l, float4 cmp)
{
    return 1.0 - whengt(l, cmp);
}

float4 when_eq(float4 x, float4 y)
{
    return 1.0 - abs(sign(x - y));
}

float4 and(float4 a, float4 b)
{
    return a * b;
}

float4 or(float4 a, float4 b)
{
    return min(a + b, 1.0);
}

float4 xor(float4 a, float4 b)
{
    return (a + b) % 2.0;
}

float4 not(float4 a)
{
    return 1.0 - a;
}


static const float4 encode = float4(16777216, 1.0 / 65536, 1.0 / 256, 1.0 / 255.0); 
float4 FloatToRGB(float v)
{
    uint vi = (uint) v;
    float4 c = (float4)0;
    c.r = vi >> 16;
    c.g = vi >> 8 & 0xFF;
    c.b = vi & 0xFF;
    c.rgb *= encode.w;
    c.a = 1;
    return c;
}

float RGBToFloat(float4 c)
{
    c *= 255;
    uint v = (uint) c.r << 16 + (uint) c.g << 8 + (uint) c.b;
    return v;
}

float3 getLookDir(float4x4 viewMatrix)
{
    return viewMatrix._m02_m12_m22;
}
#ifdef VOLUME
float4 getBoxEntryPoint(float3 localCamPos, float3 localCamVec, VolumePS_INPUT input)
{
    const float3 off = float3(0.5, 0.5, 0.5);
    float steps = floor(1 / stepSize * actualSampleDist);
    localCamPos += off;
    float3 invRayDir = 1 / localCamVec;
    float3 firstIntersections = (0 - localCamPos) * invRayDir;
    float3 secondIntersections = (1 - localCamPos) * invRayDir;
    float3 closest = min(firstIntersections, secondIntersections);
    float3 furthest = max(firstIntersections, secondIntersections);
    
    float t0 = max(closest.x, max(closest.y, closest.z));
    float t1 = min(furthest.x, min(furthest.y, furthest.z));
   
    float planeOffset = 1 - frac((t0 - length(localCamPos) - 0.5) * steps);
    t0 += (planeOffset / steps) * enablePlaneAlignment;
    t0 = max(0, t0);
    float thickness = max(0, t1 - t0);
    float3 entry = localCamPos + max(0, t0) * localCamVec;

    // Determine actual depth. If opaque objects is inside volume, ray should end after reaching the opaque object surface.
    float2 texB = input.pos.xy / vViewport.xy;
    float3 front = mul(float4(texVolumeBack.Sample(samplerVolume, texB).xyz, 1), mWorldInv).xyz + off;
    float3 v = entry - front;
    float d = max(0, dot(normalize(v), -localCamVec));
    thickness = d * min(length(v), thickness); 
    return float4(entry, thickness);
}
#endif
#endif
""";

    private const string CommonBuffersSource = """
#ifndef CBUFFERS_HLSL
#define CBUFFERS_HLSL
#pragma pack_matrix( row_major )
#include"DataStructs.hlsl"


///------------------Constant Buffers-----------------------
//--------------------------------------------------------------------------------------
// Perframe Buffers
//--------------------------------------------------------------------------------------
cbuffer cbTransforms : register(b0)
{
    float4x4 mView;
    float4x4 mProjection;
    float4x4 mViewProjection;
	// camera frustum: 
	// [fov,asepct-ratio,near,far]
    float4 vFrustum;
	// viewport:
	// [w,h,1/w,1/h]
    float4 vViewport;
    // [x, y, w, h]
    float4 vResolution;
	// camera position
    float3 vEyePos;
    bool SSAOEnabled;
    float SSAOBias;
    float SSAOIntensity;
    float TimeStamp; // by seconds
    bool IsPerspective;
    float OITPower;
    float OITSlope;
    int OITWeightMode;
    float DpiScale;
};

#if defined(MESHSIMPLE)
cbuffer cbMeshSimple : register(b1)
{
// Common Parameters
    float4x4 mWorld;
    bool bHasInstances = false;
    float3 padding1;
};
#endif

#if defined(MESH)
//Per model shares between Phong material and PBR material
cbuffer cbMesh : register(b1) 
{
// Common Parameters
    float4x4 mWorld;
    bool bInvertNormal = false;
    bool bHasInstances = false;
    bool bHasInstanceParams = false;
    bool bHasBones = false;
    float4 vParams = float4(0, 0, 0, 0); //Shared with models
    float4 vColor = float4(1, 1, 1, 1); //Shared with models
    float4 wireframeColor;
    bool3 bParams; // Shared with models for enable/disable features
    bool bBatched = false;

// Material Parameters changable
	float minTessDistance = 1;
	float maxTessDistance = 100;
	float minTessFactor = 4;
	float maxTessFactor = 1;

    float4 vMaterialDiffuse = 0.5f; //Kd := surface material's diffuse coefficient
    float4 vMaterialAmbient = 0.25f; //Ka := surface material's ambient coefficient.
    float4 vMaterialEmissive = 0.0f; //Ke := surface material's emissive coefficient
#if !defined(PBR)
    float4 vMaterialSpecular = 0.0f; //Ks := surface material's specular coefficient. If using PBR, vMaterialReflect = float4(ConstantAO, ConstantRoughness, ConstantMetallic, ConstantReflectance);
    float4 vMaterialReflect = 0.0f; //Kr := surface material's reflectivity coefficient. If using PBR, vMaterialSpecular = float4(ClearCoat, ClearCoatRoughness, 0, 0)
#endif
#if defined(PBR)
    float ConstantAO;
    float ConstantRoughness;
    float ConstantMetallic;
    float ConstantReflectance;
    float ClearCoat;
    float ClearCoatRoughness;
    float padding1;
    bool bHasAOMap;
#endif
    bool bHasDiffuseMap = false;
    bool bHasNormalMap = false;
    bool bHasCubeMap = false;
    bool bRenderShadowMap = false;
    bool bHasEmissiveMap = false;
#if !defined(PBR)
    bool bHasAlphaMap = false; // If using PBR, this is used as HasRMAMap.
    bool bHasSpecularMap;    
#endif
#if defined(PBR)
    bool bHasRMMap;    
    bool bHasIrradianceMap; 
#endif
    bool bAutoTengent;
    bool bHasDisplacementMap = false;
    bool bRenderPBR = false;  
    bool bRenderFlat = false; //Enable flat normal rendering
    float sMaterialShininess = 1.0f; //Ps := surface material's shininess

    float4 displacementMapScaleMask = float4(0, 0, 0, 1);
    float4 uvTransformR1;
    float4 uvTransformR2;
    float vertColorBlending;
    float3 padding4;
};
#endif

#if defined(SCREENDUPLICATION)
    cbuffer cbScreenClone : register(b9)
    {
        float4 VertCoord[4];
        float4 TextureCoord[4];
        float4 CursorVertCoord[4];
    };
#endif
#if defined(SCREENQUAD)
    cbuffer cbScreenQuad : register(b9)
    {
        float4x4 mWorld;
        float4 VertCoord[4];
        float4 TextureCoord[4];
    };
#endif
cbuffer cbLights : register(b3)
{
    LightStruct Lights[LIGHTS];
    float4 vLightAmbient = float4(0.2f, 0.2f, 0.2f, 1.0f);
    int NumLights;
    bool bHasEnvironmentMap;
    int NumEnvironmentMapMipLevels;
    float padding;
};

#if defined(POINTLINE) // model for line, point and billboard
//Per model
cbuffer cbPointLineModel : register(b4)
{
    float4x4 mWorld;
    bool bHasInstances = false;
    bool bHasInstanceParams = false;
	float2 padding1;
    float4 pfParams = float4(0, 0, 0, 0); //Shared with line, points and billboard
    float4 pColor = float4(1, 1, 1, 1); //Shared with line, points and billboard
    bool fixedSize;
	bool3 pbParams;
    bool enableDistanceFading;
    float fadeNearDistance;
    float fadeFarDistance;
    bool bHasTexture = false;
    float pTextureScale = 1;
    float pAlphaThreshold = 0;
    bool pEnableBlending = 0;
    float pBlendingFactor = 0;
};
#endif
#if defined(VOLUME) // model for line, point and billboard
//Per model
cbuffer cbVolumeModel : register(b4)
{
    float4x4 mWorld;
    float4x4 mWorldInv;
    float4 pColor;
    float stepSize;
    uint iterationOffset;
    bool enablePlaneAlignment;
    uint maxIterations;
    bool bHasGradientMapX;
    float isoValue;
    float baseSampleDist = .5f;
    float actualSampleDist = .5f;
};
#endif
#if defined(PARTICLE) // model for line, point and billboard
//Per model
cbuffer cbParticleModel : register(b4)
{
    float4x4 mWorld;
    bool bHasInstances = false;
    bool bHasInstanceParams = false;
    bool bHasTexture = false;
	float padding1;
};
#endif
#if defined(PLANEGRID) 
cbuffer cbPlaneGridModel : register(b4)
{
    float4x4 mWorld;
    float gridSpacing; 
    float gridThickness;
    float fadingFactor;
    float planeD;
    float4 pColor;
    float4 gColor;
    bool hasShadowMap;
    int axis;
    int type;
    float padding3;
};
#endif
cbuffer cbShadow : register(b5)
{
    float2 vShadowMapSize;
    bool bHasShadowMap;
    float paddingShadow0;
    float4 vShadowMapInfo;
    float4x4 vLightView;
    float4x4 vLightProjection;
};
#if defined(CLIPPLANE)
cbuffer cbClipping : register(b6)
{
    bool4 EnableCrossPlane;
    bool4 EnableCrossPlane5To8;
    float4 CrossSectionColors;
    int CuttingOperation;
    float3 paddingClipping;
    float4 CrossPlane1Params;
    float4 CrossPlane2Params;
    float4 CrossPlane3Params;
    float4 CrossPlane4Params;
    float4 CrossPlane5Params;
    float4 CrossPlane6Params;
    float4 CrossPlane7Params;
    float4 CrossPlane8Params;
}
#endif

#if defined(BORDEREFFECTS)

cbuffer cbBorderEffect : register(b6)
{
    float4 Color;
    float4x4 Param;
    float viewportScale; // Used to handle if using lower resolution render target for bluring. Scale = Full Res / Low Res;
    float3 padding9;
};
#endif

#if defined(PARTICLE)
cbuffer cbParticleFrame : register(b7)
{
    uint NumParticles;
    float3 ExtraAccelation;

    float TimeFactors;
    float3 DomainBoundsMax;

    float3 DomainBoundsMin;
    uint CumulateAtBound;

    float3 ConsumerLocation;
    float ConsumerGravity;

    float ConsumerRadius;
    float3 RandomVector;

    uint RandomSeed;
    uint NumTexCol;
    uint NumTexRow;
    bool AnimateByEnergyLevel;
    float2 ParticleSize;
    float Turbulance;
    float pad0;
};

cbuffer cbParticleCreateParameters : register(b8)
{
    float3 EmitterLocation;
    float InitialEnergy;

    float EmitterRadius;
    float2 pad2;
    float InitialVelocity;

    float4 ParticleBlendColor;

    float EnergyDissipationRate; //Energy dissipation rate per second
    float3 InitialAcceleration;
};
#endif

#if defined(SSAO)
static const uint SSAOKernalSize = 32;
cbuffer cbSSAO : register(b1)
{
    float4 kernel[SSAOKernalSize];
    float2 noiseScale;
    int texScale; // Used when viewport size does not match texture size
    float radius;    
    float4x4 invProjection;
}
#endif

cbuffer cbMorphTarget : register(b9)
{
	int mtCount; //Number of targets
	int mtPitch; //Pitch between targets for deltas buffer
}

///------------------Textures---------------------
Texture2D texDiffuseMap : register(t0);
Texture2D<float3> texNormalMap : register(t1);

#if !defined(PBR)
Texture2D texAlphaMap : register(t2);
Texture2D texSpecularMap : register(t3);
Texture2D<float3> texEmissiveMap : register(t5);
#endif
#if defined(PBR)
Texture2D<float3> texRMMap    : register(t2);
Texture2D<float> texAOMap : register(t3);
Texture2D<float3> texEmissiveMap : register(t5);
TextureCube<float3> texIrradianceMap : register(t21);
#endif
Texture2D<float3> texDisplacementMap : register(t4);
TextureCube<float3> texCubeMap : register(t20); // Radiance Map

Texture2D<float> texShadowMap : register(t30);

Texture2D texSSAOMap : register(t31);

#if defined(SSAO)
Texture2D<float3> texSSAONoise : register(t32);
Texture2D<float> texSSAODepth : register(t33);
#endif

Texture2D texParticle : register(t0);
StructuredBuffer<Particle> SimulationState : register(t0);
Texture2D billboardTexture : register(t0);; // billboard text image

Texture2D texOITColor : register(t10);
Texture2D texOITAlpha : register(t11);

Texture1D texColorStripe1DX : register(t12);
Texture1D texColorStripe1DY : register(t13);

StructuredBuffer<matrix> skinMatrices : register(t40);

StructuredBuffer<float> morphTargetWeights : register(t60);
StructuredBuffer<float3> morphTargetDeltas : register(t61);
StructuredBuffer<int> morphTargetOffsets : register(t62);

Texture2D texSprite : register(t50);

Texture3D texVolume : register(t0);
Texture2D texVolumeFront : register(t1);
Texture2D texVolumeBack : register(t2);
///------------------Samplers-------------------
SamplerState samplerSurface : register(s0);
SamplerState samplerIBL : register(s1);

SamplerState samplerDisplace : register(s3);

SamplerState samplerCube : register(s4);

SamplerComparisonState samplerShadow : register(s5);

SamplerState samplerParticle : register(s6);

SamplerState samplerBillboard : register(s7);

SamplerState samplerSprite : register(s8);

SamplerState samplerVolume : register(s9);

#if defined(SSAO)
SamplerState samplerNoise : register(s1);
#endif
///---------------------UAV-----------------------------

ConsumeStructuredBuffer<Particle> CurrentSimulationState : register(u0);
AppendStructuredBuffer<Particle> NewSimulationState : register(u1);


#endif
""";

    private const string DataStructsSource = """
#ifndef DATASTRUCTS_FX
#define DATASTRUCTS_FX
#pragma pack_matrix( row_major )
//--------------------------------------------------------------------------------------
// VERTEX AND PIXEL SHADER INPUTS
//--------------------------------------------------------------------------------------
#define LIGHTS 8
//--------------------------------------------------------------------------------------
// Light Buffer
//--------------------------------------------------------------------------------------
struct LightStruct
{
    int iLightType; //4
    float3 paddingL;
	// the light direction is here the vector which looks towards the light
    float4 vLightDir; //8
    float4 vLightPos; //12
    float4 vLightAtt; //16
    float4 vLightSpot; //(outer angle , inner angle, falloff, free), 20
    float4 vLightColor; //24
    matrix mLightView; //40
    matrix mLightProj; //56
};

struct VSSkinnedInput
{
    float4 p : POSITION;
    float3 n : NORMAL;
    float3 t1 : TANGENT;
    float3 t2 : BINORMAL;
    int4 bones : BONEIDS;
    float4 boneWeights : BONEWEIGHTS;
};

struct VSSkinnedOutput
{
    float4 p : POSITION;
    float3 n : NORMAL;
    float3 t1 : TANGENT;
    float3 t2 : BINORMAL;
};

struct VSInput
{
	float4 p : POSITION;
	float3 n : NORMAL;
	float3 t1 : TANGENT;
	float3 t2 : BINORMAL;
	float2 t : TEXCOORD;
    float4 c : COLOR;
	float4 mr0 : TEXCOORD1;
	float4 mr1 : TEXCOORD2;
	float4 mr2 : TEXCOORD3;
	float4 mr3 : TEXCOORD4;
};

struct VSInputBatched
{
    float4 p : POSITION;
    float3 n : NORMAL;
    float3 t1 : TANGENT;
    float3 t2 : BINORMAL;
    float2 t : TEXCOORD;
    float4 c : COLOR; // if batched x: diffuse, y: emissive, z: specular, w: reflect; PBR : albedo
    float4 c1 : COLOR1; // if batched x: ambient, y: specular shininess, z: diffuse alpha; PBR : AO, Roughtness, Metallic
};

struct VSBoneSkinInput
{
	float4 p : POSITION;
	float3 n : NORMAL;
	float3 t1 : TANGENT;
	float3 t2 : BINORMAL;
	float2 t : TEXCOORD;
	float4 c : COLOR;

	float4 mr0 : TEXCOORD1;
	float4 mr1 : TEXCOORD2;
	float4 mr2 : TEXCOORD3;
	float4 mr3 : TEXCOORD4;

	int4 bones : BONEIDS;
	float4 boneWeights : BONEWEIGHTS;

};

//--------------------------------------------------------------------------------------
// VERTEX AND PIXEL SHADER INPUTS
//--------------------------------------------------------------------------------------
struct VSInstancingInput
{
	float4 p : POSITION;
	float3 n : NORMAL;
	float3 t1 : TANGENT;
	float3 t2 : BINORMAL;
	float2 t : TEXCOORD;
	float4 c : COLOR;

	float4 mr0 : TEXCOORD1;
	float4 mr1 : TEXCOORD2;
	float4 mr2 : TEXCOORD3;
	float4 mr3 : TEXCOORD4;

	float4 diffuseC : COLOR1;
	float4 emissiveC : COLOR2;
	float2 tOffset : TEXCOORD5;
};

//--------------------------------------------------------------------------------------
struct PSInput
{
	float4 p : SV_POSITION;
    float4 vEye : POSITION0;
    float3 n : NORMAL; // normal
    float4 wp : POSITION1;
	float4 sp : TEXCOORD1;
	float2 t : TEXCOORD0; // tex coord	
	float3 t1 : TANGENT; // tangent
	float3 t2 : BINORMAL; // bi-tangent	
	float4 c : COLOR; // solid color (for debug)
    float4 c2 : COLOR1; //vMaterialEmissive
    float4 cDiffuse : COLOR2; //vMaterialDiffuse
};

struct PSPlaneGridInput
{
    float4 p : SV_POSITION;
    float2 uv : POSITION0;
    float3 wp : POSITION1;
    float4 sp : POSITION2;
};

struct PSWireframeInput
{
    float4 p : SV_POSITION;
    float z : POSITION0;
};

struct PSInputClip
{
    float4 p : SV_POSITION;
    float4 vEye : POSITION0;
    float3 n : NORMAL; // normal
    float4 wp : POSITION1;
    float4 sp : TEXCOORD1;
    float2 t : TEXCOORD0; // tex coord	
    float3 t1 : TANGENT; // tangent
    float3 t2 : BINORMAL; // bi-tangent	
    float4 c : COLOR; // solid color (for debug)
    float4 c2 : COLOR1; //vMaterialEmissive + vMaterialAmbient * vLightAmbient
    float4 cDiffuse : COLOR2; //vMaterialDiffuse
    float4 clipPlane : SV_ClipDistance0;
    float4 clipPlane5To8 : SV_ClipDistance1;
};

struct PSInputXRay
{
	float4 p : SV_POSITION;
	float4 vEye : POSITION0;
	float3 n : NORMAL; // normal
};

struct PSShadow
{
    float4 p : SV_POSITION;
};


struct PSOITOutput
{
    float4 color : SV_Target0;
    float4 alpha : SV_Target1;
};
//--------------------------------------------------------------------------------------
// CUBE-MAP funcs
//--------------------------------------------------------------------------------------
struct PSInputCube
{
	float4 p : SV_POSITION;
	float3 t : TEXCOORD;
	float4 c : COLOR;
};

//--------------------------------------------------------------------------------------
// Billboard VERTEX AND PIXEL SHADER INPUTS
//--------------------------------------------------------------------------------------
//struct VSInputBT
//{
//	float4 p : POSITION;
//    float4 foreground : COLOR;
//    float4 background : COLOR1;
//	float4 t : TEXCOORD0; // t.xy = texture coords, t.zw = offset in pixels.
//	float4 mr0 : TEXCOORD1;
//	float4 mr1 : TEXCOORD2;
//	float4 mr2 : TEXCOORD3;
//	float4 mr3 : TEXCOORD4;
//};

struct VSInputBT
{
    float4 p : POSITION;
    float4 foreground : COLOR;
    float4 background : COLOR1;
    float2 t0 : TEXCOORD0;
    float2 t3 : TEXCOORD1;
    float2 offTL : TEXCOORD2;
    float2 offTR : TEXCOORD3;
    float2 offBL : TEXCOORD4;
    float2 offBR : TEXCOORD5;
    float4 mr0 : TEXCOORD6;
    float4 mr1 : TEXCOORD7;
    float4 mr2 : TEXCOORD8;
    float4 mr3 : TEXCOORD9;
};

struct GSInputBT
{
    float4 p : POSITION;
    float4 foreground : COLOR;
    float4 background : COLOR1;
    float2 t0 : TEXCOORD0;
    float2 t3 : TEXCOORD1;
    float2 offTL : TEXCOORD2;
    float2 offTR : TEXCOORD3;
    float2 offBL : TEXCOORD4;
    float2 offBR : TEXCOORD5;
};

struct VSInputBTInstancing
{
	float4 p : POSITION;
    float4 foreground : COLOR;
    float4 background : COLOR1;
    float2 t0 : TEXCOORD0;
    float2 t3 : TEXCOORD1;
    float2 offTL : TEXCOORD2;
    float2 offTR : TEXCOORD3;
    float2 offBL : TEXCOORD4;
    float2 offBR : TEXCOORD5;
    float4 mr0 : TEXCOORD6;
    float4 mr1 : TEXCOORD7;
    float4 mr2 : TEXCOORD8;
    float4 mr3 : TEXCOORD9;

	float4 diffuseC : COLOR2;
	float2 tScale : TEXCOORD10;
	float2 tOffset : TEXCOORD11;
};

struct PSInputBT
{
	float4 p : SV_POSITION;
	float4 foreground : COLOR;
    float4 background : COLOR1;
    noperspective
	float2 t : TEXCOORD;
    float4 vEye : POSITION0;
};

//--------------------------------------------------------------------------------------
// Point Or Line VERTEX AND PIXEL SHADER INPUTS
//--------------------------------------------------------------------------------------
struct VSInputPS
{
	float4 p : POSITION;
	float4 c : COLOR;
	float4 mr0 : TEXCOORD0;
	float4 mr1 : TEXCOORD1;
	float4 mr2 : TEXCOORD2;
	float4 mr3 : TEXCOORD3;
};

struct GSInputPS
{
    float4 p : SV_POSITION;
    float4 wp : POSITION0;
	float4 c : COLOR;
    float4 vEye : POSITION1;
};

struct PSInputPS
{
	float4 p : SV_POSITION;
    float4 vEye : POSITION0;
	float4 c : COLOR;   
    float3 tex : TEXCOORD0;
    noperspective
    float3 t : TEXCOORD1;
};

//--------------------------------------------------------------------------------------
// SHADER STRUCTURES
//--------------------------------------------------------------------------------------
struct HSConstantDataOutput
{
	float Edges[3] : SV_TessFactor;
	float Inside : SV_InsideTessFactor;
	float Sign : SIGN;
   
	float3 f3B210 : POSITION3;
	float3 f3B120 : POSITION4;
	float3 f3B021 : POSITION5;
	float3 f3B012 : POSITION6;
	float3 f3B102 : POSITION7;
	float3 f3B201 : POSITION8;
	float3 f3B111 : CENTER;
};

//--------------------------------------------------------------------------------------
struct HSConstantDataOutputQuads
{
	float Edges[4] : SV_TessFactor;
	float Inside[2] : SV_InsideTessFactor;
	float Sign : SIGN;
	float3 vEdgePos[8] : EDGEPOS;
	float3 vInteriorPos[4] : INTERIORPOS;
};

//--------------------------------------------------------------------------------------
struct HSInput
{
	float3 p : POSITION;
	float2 t : TEXCOORD0;
	float3 n : TEXCOORD1;
	float3 t1 : TEXCOORD2;
	float3 t2 : TEXCOORD3;
	float4 c : COLOR;
    float4 c2 : COLOR1;
    float tessF : TESS;
};

//--------------------------------------------------------------------------------------
struct VSIn
{
	float4 p : POSITION;
	float3 n : NORMAL;
	float3 t1 : TANGENT;
	float3 t2 : BINORMAL;
	float2 t : TEXCOORD;
	float4 c : COLOR;
};

//
struct PSInputScreenQuad
{
    float4 p : POSITION;
    float4 c : COLOR;
};

//----------------Particle---------------------
struct Particle
{
    float3 position;
    float initEnergy;
    float3 velocity;
    float energy;
    float4 color;
    float3 initAccelleration;
    float dissipRate;
    uint2 TexColRow;
};

//--------------------------------------------------------------------------------
// Inter-stage structures
//--------------------------------------------------------------------------------
struct ParticleVS_INPUT
{
    float4 mr0 : TEXCOORD1;
    float4 mr1 : TEXCOORD2;
    float4 mr2 : TEXCOORD3;
    float4 mr3 : TEXCOORD4;
};
//--------------------------------------------------------------------------------
struct ParticleGS_INPUT
{
    float3 position : Position;
    float energy : Energy;
    float4 color : COLOR0;
    float initEnergy : Energy1;
    uint2 texColRow : TexOff;
};
//--------------------------------------------------------------------------------
struct ParticlePS_INPUT
{
    float4 position : SV_Position;    
	float4 color : COLOR0;
    noperspective
    float2 texcoords : TEXCOORD0;
    float opacity : OPACITY0;
    float z : Position0;
};

struct ScreenDupVS_INPUT
{
    float4 Pos : SV_POSITION;
    noperspective
    float2 Tex : TEXCOORD0;
};

struct MeshOutlinePS_INPUT
{
    float4 Pos : SV_POSITION;
    noperspective
    float2 Tex : TEXCOORD0;
};

struct SpriteVS_INPUT
{
    float2 Pos : POSITION;
    float2 UV : TEXCOORD0;
    float4 Color : COLOR0;
};

struct SpritePS_INPUT
{
    float4 Pos : SV_POSITION;
    float4 Color : COLOR0;
    float2 UV : TEXCOORD0;   
};

struct VolumePS_INPUT
{
    float4 pos : SV_POSITION;
    float4 wp : POSITION0;
};
#endif
""";

    private const string psCommonSource = """
#ifndef PSCOMMON_HLSL
#define PSCOMMON_HLSL

#define MESH
#include"..\Common\Common.hlsl"

float lookUp(in float4 loc, in float2 offset)
{
    return texShadowMap.SampleCmpLevelZero(samplerShadow, loc.xy + offset, loc.z);
}

//--------------------------------------------------------------------------------------
// get shadow color
//--------------------------------------------------------------------------------------
float shadowStrength(float4 sp)
{
    sp = sp / sp.w;
    float2 xy = abs(sp).xy - float2(1, 1);
    
    if (xy.x > 0 || xy.y > 0 || sp.z < 0 || sp.z > 1)
    {
        return 1;
    }
    else
    {
        sp.x = mad(0.5, sp.x, 0.5f);
        sp.y = mad(-0.5, sp.y, 0.5f);

	    //apply shadow map bias
        sp.z -= vShadowMapInfo.z;

	    //// --- not in shadow, hard cut
        //float shadowMapDepth = texShadowMap.Sample(PointSampler, sp.xy+offsets[1]).r;
        //return whengt(shadowMapDepth, sp.z);

	    //// --- basic hardware PCF - single texel
        //float shadowFactor = texShadowMap.SampleCmpLevelZero(samplerShadow, sp.xy, sp.z).r;

	    //// --- PCF sampling for shadow map
        float sum = 0;
        float x = 0, y = 0;
        const float range = 1.5;
        float2 scale = 1 / vShadowMapSize;

	    //// ---perform PCF filtering on a 4 x 4 texel neighborhood
	    [unroll]
        for (y = -range; y <= range; y += 1.0f)
        {
            for (x = -range; x <= range; x += 1.0f)
            {
                sum += lookUp(sp, float2(x, y) * scale);
            }
        }

        float shadowFactor = sum / 16;

        float fixTeil = 1 - vShadowMapInfo.x;
        float nonTeil = vShadowMapInfo.x;
	    // now, put the shadow-strengh into the 0-nonTeil range
        nonTeil = shadowFactor * nonTeil;
        return (fixTeil + nonTeil);
    }
}

#define WeightModes_LinearA 0
#define WeightModes_LinearB 1
#define WeightModes_LinearC 2
#define WeightModes_NonLinear 3

//Ref http://jcgt.org/published/0002/02/09/
PSOITOutput calculateOIT(in float4 color, float z, float zw)
{
    PSOITOutput output = (PSOITOutput) 0;
    float weight = 1;
    z = z - vFrustum.z;
    if (OITWeightMode == WeightModes_LinearA)
        weight = max(0.01f, min(3000.0f, 100 / (0.00001f + pow(abs(z) / 5.0f, abs(OITPower)) + pow(abs(z) / 200.0f, abs(OITPower) * 2))));
    else if (OITWeightMode == WeightModes_LinearB)
        weight = max(0.01f, min(3000.0f, 100 / (0.00001f + pow(abs(z) / 10.0f, abs(OITPower)) + pow(abs(z) / 200.0f, abs(OITPower) * 2))));
    else if (OITWeightMode == WeightModes_LinearC)
        weight = max(0.01f, min(3000.0f, 0.3f / (0.00001f + pow(abs(z) / 200.0f, abs(OITPower)))));
    else if (OITWeightMode == WeightModes_NonLinear)
        weight = max(0.01f, 3e3 * pow(clamp(1.0f - zw * max(OITSlope, 1), 0, 1), abs(OITPower)));

    output.color = float4(color.rgb * color.a, color.a) * (color.a * weight);
        // Blend Func: GL_ZERO, GL_ONE_MINUS_SRC_ALPHA
    output.alpha.a = color.a;
    return output;
}

#if defined(PBR)
static const float PI = 3.14159265f;
static const float EPSILON = 1e-6f;

// Shlick's approximation of Fresnel
// https://en.wikipedia.org/wiki/Schlick%27s_approximation
float3 Fresnel_Shlick(in float3 f0, in float3 f90, in float x)
{
    return f0 + (f90 - f0) * pow(1.f - x, 5);
}

float Filament_F_Schlick(float f0, float VoH) {
    float f = pow(1.0 - VoH, 5.0);
    return f + f0 * (1.0 - f);
}

// https://google.github.io/filament/Filament.md.html#toc4.4
float3 Filament_F_Schlick(float3 f0, float VoH) {
    float f = pow(1.0 - VoH, 5.0);
    return f + f0 * (1.0 - f);
}

// Burley B. "Physically Based Shading at Disney"
// SIGGRAPH 2012 Course: Practical Physically Based Shading in Film and Game Production, 2012.
float Diffuse_Burley(in float NdotL, in float NdotV, in float LdotH, in float roughness)
{
    return Filament_F_Schlick(1, NdotL).x * Filament_F_Schlick(1, NdotV).x;
    //float fd90 = 0.5f + 2.f * roughness * LdotH * LdotH;
    //return Fresnel_Shlick(1, fd90, NdotL).x * Fresnel_Shlick(1, fd90, NdotV).x;
}

// GGX specular D (normal distribution)
// https://www.cs.cornell.edu/~srm/publications/EGSR07-btdf.pdf
float Specular_D_GGX(in float alpha, in float NdotH)
{
    const float alpha2 = alpha * alpha;
    const float lower = (NdotH * NdotH * (alpha2 - 1)) + 1;
    return alpha2 / max(EPSILON, PI * lower * lower);
}

#define MEDIUMP_FLT_MAX    65504.0
#define saturateMediump(x) min(x, MEDIUMP_FLT_MAX)
// https://google.github.io/filament/Filament.md.html#toc4.4
float Filament_D_GGX(in float linearRoughness, in float NoH, in float3 n, in float3 h) {
    float3 NxH = cross(n, h);
    float a = NoH * linearRoughness;
    float k = linearRoughness / (dot(NxH, NxH) + a * a);
    float d = k * k * (1.0 / PI);
    return saturateMediump(d);
}

// Schlick-Smith specular G (visibility) with Hable's LdotH optimization
// http://www.cs.virginia.edu/~jdl/bib/appearance/analytic%20models/schlick94b.pdf
// http://graphicrants.blogspot.se/2013/08/specular-brdf-reference.html
float G_Shlick_Smith_Hable(float alpha, float LdotH)
{
    return rcp(lerp(LdotH * LdotH, 1, alpha * alpha * 0.25f));
}

float V_Kelemen(float LoH) {
    return 0.25 / (LoH * LoH);
}
// A microfacet based BRDF.
//
// alpha:           This is roughness * roughness as in the "Disney" PBR model by Burley et al.
//
// specularColor:   The F0 reflectance value - 0.04 for non-metals, or RGB for metals. This follows model 
//                  used by Unreal Engine 4.
//
// NdotV, NdotL, LdotH, NdotH: vector relationships between,
//      N - surface normal
//      V - eye normal
//      L - light normal
//      H - half vector between L & V.
float3 Specular_BRDF(in float alpha, in float3 specularColor, in float NdotV, in float NdotL, in float LdotH, in float NdotH, in float3 N, in float3 H)
{
    // Specular D (microfacet normal distribution) component
    float specular_D = Filament_D_GGX(alpha, NdotH, N, H);//Specular_D_GGX(alpha, NdotH);

    // Specular Fresnel
    float3 specular_F = Filament_F_Schlick(specularColor, LdotH);//Fresnel_Shlick(specularColor, 1, LdotH);

    // Specular G (visibility) component
    float specular_G = G_Shlick_Smith_Hable(alpha, LdotH);

    return specular_D * specular_G * specular_F;
}

// Diffuse irradiance
float3 Diffuse_IBL(in float3 N)
{
    return texIrradianceMap.Sample(samplerIBL, N).rgb;
}

// Approximate specular image based lighting by sampling radiance map at lower mips 
// according to roughness, then modulating by Fresnel term. 
float3 Specular_IBL(in float3 N, in float3 V, in float lodBias)
{
    float mip = lodBias * NumEnvironmentMapMipLevels;
    float3 dir = reflect(-V, N);
    return texCubeMap.SampleLevel(samplerIBL, dir, mip).rgb;
}
#endif
// Christian Sch?ler, "Normal Mapping without Precomputed Tangents",?ShaderX 5, Chapter 2.6, pp. 131 ? 140
// See also follow-up blog post: http://www.thetenthplanet.de/archives/1180
float3x3 CalculateTBN(float3 p, float3 n, float2 tex)
{
    float3 dp1 = ddx(p);
    float3 dp2 = ddy(p);
    float2 duv1 = ddx(tex);
    float2 duv2 = ddy(tex);

    float3x3 M = float3x3(dp1, dp2, cross(dp1, dp2));
    float2x3 inverseM = float2x3(cross(M[1], M[2]), cross(M[2], M[0]));
    float3 t = normalize(mul(float2(duv1.x, duv2.x), inverseM));
    float3 b = normalize(mul(float2(duv1.y, duv2.y), inverseM));
    return float3x3(t, b, n);
}
float3 BiasX2(float3 x)
{
    return 2.0f * x - 1.0f;
}

float3 BiasD2(float3 x)
{
    return 0.5f * x + 0.5f;
}

float3 PeturbNormal(float3 localNormal, float3 position, float3 normal, float2 texCoord)
{
    const float3x3 TBN = CalculateTBN(position, normal, texCoord);
    return normalize(mul(localNormal, TBN));
}
#endif
""";

    private const string psMeshPBRSource = """
#ifndef PSMESHPBR_HLSL
#define PSMESHPBR_HLSL

#define MESH
#define PBR
#define CLEARCOAT

#include"..\Common\Common.hlsl"
#include"..\Common\DataStructs.hlsl"
#include"psCommon.hlsl"

float3 calcNormal(PSInput input)
{
    float3 normal = bRenderFlat ? normalize(cross(ddy(input.wp.xyz), ddx(input.wp.xyz))) : normalize(input.n);
    if (bHasNormalMap)
    {
        if (bAutoTengent)
        {
            float3 localNormal = BiasX2(texNormalMap.Sample(samplerSurface, input.t).xyz);
            normal = PeturbNormal(localNormal, input.wp.xyz, normal, input.t);
        }
        else
        {
		// Normalize the per-pixel interpolated tangent-space
            float3 tangent = normalize(input.t1);
            float3 biTangent = normalize(input.t2);

		// Sample the texel in the bump map.
            float3 bumpMap = texNormalMap.Sample(samplerSurface, input.t);
		// Expand the range of the normal value from (0, +1) to (-1, +1).
            bumpMap = mad(2.0f, bumpMap, -1.0f);
		// Calculate the normal from the data in the bump map.
            normal += mad(bumpMap.x, tangent, bumpMap.y * biTangent);
            normal = normalize(normal);
        }      
    }
    return normal;
}

float3 LightSurface(in float4 wp,
    in float3 V, in float3 N, in float3 albedo, in float roughness, in float metallic, in float ambientOcclusion, in float reflectance, in float clearCoat, in float clearCoatRoughness)
{
    const float NdotV = saturate(dot(N, V));

    // Burley roughness bias
    const float alpha = roughness * roughness;

    // Blend base colors
    const float3 c_diff = lerp(albedo, float3(0, 0, 0), metallic) * ambientOcclusion;
    const float3 c_spec = 0.16 * reflectance * reflectance * (1 - metallic) + albedo * metallic; //lerp(reflectance, albedo, metallic) * ambientOcclusion;
#if defined(CLEARCOAT)
    // remapping and linearization of clear coat roughness
    clearCoatRoughness = lerp(0.089, 0.6, clearCoatRoughness);
    float clearCoatLinearRoughness = clearCoatRoughness * clearCoatRoughness;
#endif
    // Output color
    float3 acc_color = 0;

    // Accumulate light values
    for (int i = 0; i < NumLights; i++)
    {


        if (Lights[i].iLightType == 1)
        {
            // light vector (to light)
            const float3 L = normalize(Lights[i].vLightDir.xyz);

            // Half vector
            const float3 H = normalize(L + V);

            // products
            const float NdotL = saturate(dot(N, L));
            const float LdotH = saturate(dot(L, H));
            const float NdotH = saturate(dot(N, H));
            // Diffuse & specular factors
            float diffuse_factor = Diffuse_Burley(NdotL, NdotV, LdotH, roughness);
            float3 diffuse = c_diff * diffuse_factor;
            float3 specular = Specular_BRDF(alpha, c_spec, NdotV, NdotL, LdotH, NdotH, N, H);
          
#if defined(CLEARCOAT)
            float Dc = Filament_D_GGX(clearCoatLinearRoughness, NdotH, N, H);
            float Vc = V_Kelemen(LdotH);
            float Fc = Filament_F_Schlick(0.04, LdotH) * clearCoat; // clear coat strength
            float Frc = (Dc * Vc) * Fc;
            // Directional light
            acc_color += NdotL * Lights[i].vLightColor.rgb * ((diffuse + specular * (1 - Fc)) * (1 - Fc) + Frc);
#endif
#if !defined(CLEARCOAT)
            acc_color += NdotL * Lights[i].vLightColor.rgb * (diffuse + specular);
#endif
        }
        else if (Lights[i].iLightType == 2)
        {
            float3 L = (float3) (Lights[i].vLightPos - wp); // light dir
            float dl = length(L); // light distance
            if (Lights[i].vLightAtt.w < dl)
            {
                continue;
            }
            L = L / dl; // normalized light dir						
            const float3 H = normalize(V + L); // half direction for specular
            // products
            const float NdotL = saturate(dot(N, L));
            const float LdotH = saturate(dot(L, H));
            const float NdotH = saturate(dot(N, H));
            // Diffuse & specular factors
            float diffuse_factor = Diffuse_Burley(NdotL, NdotV, LdotH, roughness);
            float3 diffuse = c_diff * diffuse_factor;
            float3 specular = Specular_BRDF(alpha, c_spec, NdotV, NdotL, LdotH, NdotH, N, H);
            float att = 1.0f / (Lights[i].vLightAtt.x + Lights[i].vLightAtt.y * dl + Lights[i].vLightAtt.z * dl * dl);
#if defined(CLEARCOAT)
            float Dc = Filament_D_GGX(clearCoatLinearRoughness, NdotH, N, H);
            float Vc = V_Kelemen(LdotH);
            float Fc = Filament_F_Schlick(0.04, LdotH) * clearCoat; // clear coat strength
            float Frc = (Dc * Vc) * Fc;
            acc_color = mad(att, NdotL * Lights[i].vLightColor.rgb * ((diffuse + specular * (1 - Fc)) * (1 - Fc) + Frc), acc_color);
#endif
#if !defined(CLEARCOAT)
            acc_color = mad(att, NdotL * Lights[i].vLightColor.rgb * (diffuse + specular), acc_color);
#endif
        }
        else if (Lights[i].iLightType == 3)
        {
            float3 L = (float3) (Lights[i].vLightPos - wp); // light dir
            float dl = length(L); // light distance
            if (Lights[i].vLightAtt.w < dl)
            {
                continue;
            }
            L = L / dl; // normalized light dir					
            float3 H = normalize(V + L); // half direction for specular
            float3 sd = normalize((float3) Lights[i].vLightDir); // missuse the vLightDir variable for spot-dir

            const float NdotL = saturate(dot(N, L));
            const float LdotH = saturate(dot(L, H));
            const float NdotH = saturate(dot(N, H));
            // Diffuse & specular factors
            float diffuse_factor = Diffuse_Burley(NdotL, NdotV, LdotH, roughness);
            float3 diffuse = c_diff * diffuse_factor;
            float3 specular = Specular_BRDF(alpha, c_spec, NdotV, NdotL, LdotH, NdotH, N, H);
		    /* --- this is the OpenGL 1.2 version (not so nice) --- */
		    //float spot = (dot(-d, sd));
		    //if(spot > cos(vLightSpot[i].x))
		    //	spot = pow( spot, vLightSpot[i].y );
		    //else
		    //	spot = 0.0f;	
		    /* --- */

		    /* --- this is the  DirectX9 version (better) --- */
            float rho = dot(-L, sd);
            float spot = pow(saturate((rho - Lights[i].vLightSpot.x) / (Lights[i].vLightSpot.y - Lights[i].vLightSpot.x)), Lights[i].vLightSpot.z);
            float att = spot / (Lights[i].vLightAtt.x + Lights[i].vLightAtt.y * dl + Lights[i].vLightAtt.z * dl * dl);
#if defined(CLEARCOAT)
            float Dc = Filament_D_GGX(clearCoatLinearRoughness, NdotH, N, H);
            float Vc = V_Kelemen(LdotH);
            float Fc = Filament_F_Schlick(0.04, LdotH) * clearCoat; // clear coat strength
            float Frc = (Dc * Vc) * Fc;
            acc_color = mad(att, NdotL * Lights[i].vLightColor.rgb * ((diffuse + specular * (1 - Fc)) * (1 - Fc) + Frc), acc_color);
#endif
#if !defined(CLEARCOAT)
            acc_color = mad(att, NdotL * Lights[i].vLightColor.rgb * (diffuse + specular), acc_color);
#endif
        }
    }
    if (bHasIrradianceMap)
    {
        // Add diffuse irradiance
        float3 diffuse_env = Diffuse_IBL(N);
        acc_color += c_diff * diffuse_env;
    }
    float3 specular_env = vLightAmbient.rgb * ambientOcclusion;
#if defined(CLEARCOAT)
    float3 clearCoatColor = (float3) 0;
    float Fc = Filament_F_Schlick(0.04, NdotV) * clearCoat;
#endif
    if (bHasCubeMap)
    {
    // Add specular radiance 
        specular_env = Specular_IBL(N, V, roughness);
#if defined(CLEARCOAT)
        clearCoatColor = Specular_IBL(N, V, clearCoatRoughness) * Fc;
#endif
    }

    acc_color += c_spec * specular_env;

#if defined(CLEARCOAT)
    acc_color *= sqrt(1 - Fc);
    acc_color += clearCoatColor;
#endif
    return acc_color;
}

float4 main(PSInput input) : SV_Target
{
        // vectors
    const float3 V = normalize(input.vEye.xyz); // view vector

    float3 N = calcNormal(input);
    float3 color = (float3) 0;

    float4 albedo = float4(input.cDiffuse.xyz, 1);
    // glTF2 defines occlusion as R channel, roughness as G channel, metalness as B channel 
    float3 RMA = float3(ConstantAO, ConstantRoughness, ConstantMetallic);
    if (bHasDiffuseMap)
    {
        albedo *= texDiffuseMap.Sample(samplerSurface, input.t);
    }
    albedo = lerp(albedo, input.c, vertColorBlending);
    if (bHasRMMap)
    {
        RMA.gb *= texRMMap.Sample(samplerSurface, input.t).gb;
    }
    if (bHasAOMap)
    {
        RMA.r *= texAOMap.Sample(samplerSurface, input.t).r;
    }
    else if (SSAOEnabled)
    {
        float2 quadTex = input.p.xy * vResolution.zw;
        RMA.r *= texSSAOMap.SampleLevel(samplerSurface, quadTex, 0).r;
    }
    color = LightSurface(input.wp, V, N, albedo.rgb, RMA.g, RMA.b, RMA.r, ConstantReflectance, ClearCoat, ClearCoatRoughness);
    float s = 1;
    if (bHasShadowMap)
    {
        if (bRenderShadowMap)
        {
            float d = dot(getLookDir(vLightView), N);
            if (d > 0)
            {
                s = shadowStrength(input.sp);
            }
        }
    }
    color.rgb *= s;
    float3 emissive = vMaterialEmissive.rgb;
    if (bHasEmissiveMap)
    {
        emissive *= texEmissiveMap.Sample(samplerSurface, input.t).rgb;
    }
    float3 ambient = vLightAmbient.rgb * RMA.r;
    color += emissive + ambient;
    return float4(color, albedo.a * input.cDiffuse.a);
}
#endif
""";

}
