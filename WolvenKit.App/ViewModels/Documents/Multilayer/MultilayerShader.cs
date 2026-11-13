using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HelixToolkit.SharpDX.Core.Shaders;
using D3DC = SharpDX.D3DCompiler;
using D3D11 = SharpDX.Direct3D11;

namespace WolvenKit.App.ViewModels.Documents.Multilayer;

/// <summary>
/// Compiles the multilayer pixel shader once per process (D3DCompiler, ps_5_0) and holds the
/// binding layout shared by the HLSL and <see cref="MultilayerPBRMaterialVariable"/>.
/// </summary>
public static class MultilayerShader
{
    /// <summary>Pass added to Helix's mesh technique.</summary>
    public const string PassName = "WolvenKitMultilayerPBR";

    /// <summary>
    /// Pass for every other opaque material: Helix's PBR with a tangent frame orthogonal to the
    /// vertex normal (no visible triangles on smooth normal-mapped surfaces).
    /// </summary>
    public const string SmoothPbrPassName = "WolvenKitSmoothPBR";

    /// <summary>
    /// Transparent counterparts of <see cref="SmoothPbrPassName"/> (hair cards, glass, decals):
    /// Helix's weighted blended OIT and depth peeling passes with the same pixel shading.
    /// </summary>
    public const string SmoothPbrOitPassName = "WolvenKitSmoothPBROIT";
    public const string SmoothPbrOitDpPassName = "WolvenKitSmoothPBROITDP";

    /// <summary>cbuffer name in the HLSL; Helix pools constant buffers by name.</summary>
    public const string ConstantBufferName = "cbMultilayer";

    /// <summary>Glass extras of the plain PBR passes (register b12).</summary>
    public const string ExtraConstantBufferName = "cbSurfaceExtra";

    /// <summary>First texture register of the pool (t64); Helix's pixel shaders stop at t33.</summary>
    public const int TextureSlot = 64;

    /// <summary>Texture pool size: t64..t127 (D3D11 allows 128 per stage).</summary>
    public const int PoolSize = 64;

    /// <summary>Sampler register (s10); Helix uses s0..s9.</summary>
    public const int SamplerSlot = 10;

    /// <summary>
    /// Debug view chosen in the UI (applied per material by the view model): 0 shaded, 1 albedo,
    /// 2 roughness, 3 metalness, 4 normal, 5 layer coverage, 6 layer mask, 7 layer tiling.
    /// </summary>
    public static int DebugMode { get; set; }

    public const int MaxLayers = 20;
    public const int VectorsPerLayer = 9;

    private static readonly object s_lock = new();
    private static bool s_compiled;
    private static byte[]? s_bytecode;
    private static byte[]? s_pbrBytecode;
    private static byte[]? s_pbrOitBytecode;
    private static byte[]? s_pbrOitDpBytecode;

    /// <summary>Why the last compile failed (null when it succeeded or has not run).</summary>
    public static string? LastError { get; private set; }

    /// <summary>
    /// Compile report: the vertex shader output layout found in the installed Helix package and
    /// any constant buffer variable that sits at a different offset than in Helix's own PBR shader.
    /// </summary>
    public static string? Diagnostics { get; private set; }

    /// <summary>
    /// True when the compile report contains something worth showing: a constant buffer that
    /// differs from the package, or the smooth PBR pass missing. The layouts alone are not logged.
    /// </summary>
    public static bool HasWarnings { get; private set; }

    /// <summary>Trilinear + anisotropic, wrap on U/V: templates, microblends and masks all repeat.</summary>
    public static D3D11.SamplerStateDescription SamplerDescription => new()
    {
        Filter = D3D11.Filter.Anisotropic,
        AddressU = D3D11.TextureAddressMode.Wrap,
        AddressV = D3D11.TextureAddressMode.Wrap,
        AddressW = D3D11.TextureAddressMode.Wrap,
        MaximumAnisotropy = 8,
        ComparisonFunction = D3D11.Comparison.Never,
        MinimumLod = 0,
        MaximumLod = float.MaxValue,
        MipLodBias = 0,
    };

    /// <summary>Compiled pixel shader, or null if compilation failed (see <see cref="LastError"/>).</summary>
    public static byte[]? GetBytecode()
    {
        lock (s_lock)
        {
            if (s_compiled)
            {
                return s_bytecode;
            }

            s_compiled = true;
            var report = new StringBuilder();
            try
            {
                var source = BuildSource(report);
                s_bytecode = Compile(source, "mlMain", out var error);
                if (s_bytecode == null)
                {
                    LastError = error;
                    Diagnostics = report.ToString();
                    HasWarnings = true;
                    return null;
                }

                LastError = null;
                CompareConstantBuffers(s_bytecode, report);
                ReportPixelInputs(s_bytecode, report);

                // Optional: without it, plain materials simply keep Helix's own PBR pass.
                try
                {
                    s_pbrBytecode = Compile(source, "pbrMain", out var pbrError);
                    if (s_pbrBytecode == null)
                    {
                        report.AppendLine("Smooth PBR pass not available: " + pbrError);
                    }
                }
                catch (Exception ex)
                {
                    report.AppendLine("Smooth PBR pass not available: " + ex.Message);
                }

                // Transparent passes, optional the same way. Depth peeling needs t100, inside
                // the texture pool's range, so it is compiled without the pool (ML_NO_POOL).
                if (s_pbrBytecode != null)
                {
                    try
                    {
                        s_pbrOitBytecode = Compile(source, "pbrOIT", out var oitError);
                        if (s_pbrOitBytecode == null)
                        {
                            report.AppendLine("Smooth PBR OIT pass not available: " + oitError);
                        }

                        s_pbrOitDpBytecode = Compile("#define ML_NO_POOL\n" + source, "pbrOITDP", out var dpError);
                        if (s_pbrOitDpBytecode == null)
                        {
                            report.AppendLine("Smooth PBR depth peeling pass not available: " + dpError);
                        }
                    }
                    catch (Exception ex)
                    {
                        report.AppendLine("Smooth PBR transparency passes not available: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // D3DCompiler throws CompilationException with the compiler output.
                LastError = ex.Message;
                s_bytecode = null;
            }

            Diagnostics = report.ToString();
            HasWarnings = s_bytecode == null ||
                          Diagnostics.Contains("differ from the package", StringComparison.Ordinal) ||
                          Diagnostics.Contains("not available", StringComparison.Ordinal) ||
                          Diagnostics.Contains("failed", StringComparison.Ordinal);
            return s_bytecode;
        }
    }

    public static bool IsAvailable => GetBytecode() != null;

    /// <summary>Compiles the shaders on a background thread (no-op once done); GetBytecode waits for it.</summary>
    public static void WarmUp()
    {
        if (s_compiled)
        {
            return;
        }

        _ = System.Threading.Tasks.Task.Run(() =>
        {
            try
            {
                GetBytecode();
            }
            catch
            {
                // reported by GetBytecode on the next call
            }
        });
    }

    /// <summary>Pixel shader of <see cref="SmoothPbrPassName"/>, or null.</summary>
    public static byte[]? GetPbrBytecode()
    {
        GetBytecode();
        return s_pbrBytecode;
    }

    /// <summary>Pixel shader of <see cref="SmoothPbrOitPassName"/>, or null.</summary>
    public static byte[]? GetPbrOitBytecode()
    {
        GetBytecode();
        return s_pbrOitBytecode;
    }

    /// <summary>Pixel shader of <see cref="SmoothPbrOitDpPassName"/>, or null.</summary>
    public static byte[]? GetPbrOitDpBytecode()
    {
        GetBytecode();
        return s_pbrOitDpBytecode;
    }

    private static byte[]? Compile(string source, string entry, out string? error)
    {
        // Compiled shaders are kept on disk, keyed by their source: compiling takes seconds per
        // start of the program, reading the cache milliseconds.
        string? cachePath = null;
        try
        {
            var key = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(
                Encoding.UTF8.GetBytes("ps_5_0|O3|" + entry + "|" + source)))[..32];
            var dir = System.IO.Path.Combine(WolvenKit.App.Services.ISettingsManager.GetTemp_OBJPath(), "ShaderCache");
            System.IO.Directory.CreateDirectory(dir);
            cachePath = System.IO.Path.Combine(dir, $"{entry}_{key}.cso");
            if (System.IO.File.Exists(cachePath))
            {
                var cached = System.IO.File.ReadAllBytes(cachePath);
                if (cached.Length > 0)
                {
                    error = null;
                    return cached;
                }
            }
        }
        catch
        {
            cachePath = null; // no cache: compile
        }

        var bytecode = CompileNow(source, entry, out error);
        if (bytecode != null && cachePath != null)
        {
            try
            {
                var tmp = cachePath + "." + Environment.ProcessId + ".tmp";
                System.IO.File.WriteAllBytes(tmp, bytecode);
                System.IO.File.Move(tmp, cachePath, overwrite: true);
            }
            catch
            {
                // another WolvenKit wrote it meanwhile, or the folder is read-only: fine
            }
        }

        return bytecode;
    }

    private static byte[]? CompileNow(string source, string entry, out string? error)
    {
        var result = D3DC.ShaderBytecode.Compile(
            source,
            entry,
            "ps_5_0",
            D3DC.ShaderFlags.OptimizationLevel3,
            D3DC.EffectFlags.None,
            "psMultilayer.hlsl");
        try
        {
            if (result.HasErrors || result.Bytecode == null)
            {
                error = result.Message;
                return null;
            }

            error = null;
            return result.Bytecode.Data;
        }
        finally
        {
            (result as IDisposable)?.Dispose();
        }
    }

    private static readonly Regex s_include = new(@"^[ \t]*#include[ \t]*""([^""]+)""[ \t]*\r?$", RegexOptions.Multiline);

    internal static string BuildSource(StringBuilder report)
    {
        var cases = new StringBuilder();
        for (var i = 0; i < PoolSize; i++)
        {
            cases.Append("        case ").Append(i)
                 .Append(": return mlTex[").Append(i)
                 .Append("].SampleGrad(mlSampler, uv, dx, dy);\n");
        }

        var body = MultilayerShaderSources.PsMultilayer
            .Replace("ML_SWITCH_CASES", cases.ToString())
            .Replace("#define ML_POOL 64", "#define ML_POOL " + PoolSize)
            .Replace("ML_VS_OUTPUT", BuildVsOutputDeclaration(report));

        // Headers are inlined by file name. Every Helix header has an include guard,
        // so a header reached twice expands to nothing the second time.
        return Inline(body, 0);
    }

    // PSInput fields of the embedded Helix header, by vertex output semantic.
    private static readonly Dictionary<string, (string Field, int Width)> s_psInputFields = new(StringComparer.OrdinalIgnoreCase)
    {
        ["SV_POSITION0"] = ("p", 4),
        ["POSITION0"] = ("vEye", 4),
        ["NORMAL0"] = ("n", 3),
        ["POSITION1"] = ("wp", 4),
        ["TEXCOORD1"] = ("sp", 4),
        ["TEXCOORD0"] = ("t", 2),
        ["TANGENT0"] = ("t1", 3),
        ["BINORMAL0"] = ("t2", 3),
        ["COLOR0"] = ("c", 4),
        ["COLOR1"] = ("c2", 4),
        ["COLOR2"] = ("cDiffuse", 4),
    };

    /// <summary>
    /// Declares MLVSOutput exactly as Helix's compiled vsMeshDefault writes it (read from its
    /// bytecode), plus mlToPSInput() copying every field PSInput knows by semantic. Interpolators
    /// are linked by register, so a PSInput that differs from the package's would scramble them
    /// (UV arriving in the wrong register).
    /// </summary>
    private static string BuildVsOutputDeclaration(StringBuilder report)
    {
        byte[]? vs = null;
        try
        {
            vs = DefaultVSShaderDescriptions.VSMeshDefault.ByteCode;
        }
        catch (Exception ex)
        {
            report.AppendLine("VS bytecode not readable: " + ex.Message);
        }

        if (vs == null || vs.Length == 0)
        {
            report.AppendLine("VS output layout: using the embedded PSInput");
            return "#define MLVSOutput PSInput\nPSInput mlToPSInput(PSInput i) { return i; }\n" +
                   "float mlKeepInputs(PSInput i) { return dot(i.p, (float4)1) + dot(i.vEye, (float4)1) + dot(i.n, (float3)1) + " +
                   "dot(i.wp, (float4)1) + dot(i.sp, (float4)1) + dot(i.t, (float2)1) + dot(i.t1, (float3)1) + dot(i.t2, (float3)1) + " +
                   "dot(i.c, (float4)1) + dot(i.c2, (float4)1) + dot(i.cDiffuse, (float4)1); }\n";
        }

        var decl = new StringBuilder("struct MLVSOutput\n{\n");
        var copy = new StringBuilder("PSInput mlToPSInput(MLVSOutput i)\n{\n    PSInput o = (PSInput)0;\n");
        var keep = new StringBuilder("float mlKeepInputs(MLVSOutput i)\n{\n    float k = 0;\n");
        var used = new HashSet<string>(StringComparer.Ordinal);
        report.AppendLine("VS output layout (vsMeshDefault):");

        using (var reflection = new D3DC.ShaderReflection(vs))
        {
            var count = reflection.Description.OutputParameters;
            for (var i = 0; i < count; i++)
            {
                var p = reflection.GetOutputParameterDescription(i);
                var mask = (int)p.UsageMask & 0xF;
                var width = 0;
                for (var bit = 0; bit < 4; bit++)
                {
                    width += (mask >> bit) & 1;
                }

                width = Math.Max(width, 1);
                var semantic = p.SemanticName + p.SemanticIndex;
                var hlslSemantic = p.SemanticName.StartsWith("SV_", StringComparison.OrdinalIgnoreCase) && p.SemanticIndex == 0
                    ? p.SemanticName
                    : semantic;

                // if/else rather than a switch: the project treats IDE0072 (missing enum cases) as an error.
                var scalar = "float";
                if (p.ComponentType == D3DC.RegisterComponentType.UInt32)
                {
                    scalar = "uint";
                }
                else if (p.ComponentType == D3DC.RegisterComponentType.SInt32)
                {
                    scalar = "int";
                }
                var type = width == 1 ? scalar : scalar + width;
                var modifier = scalar == "float" ? "" : "nointerpolation ";

                string name;
                if (s_psInputFields.TryGetValue(semantic, out var known) && used.Add(known.Field))
                {
                    name = known.Field;
                    if (known.Width == width && scalar == "float")
                    {
                        copy.Append("    o.").Append(name).Append(" = i.").Append(name).Append(";\n");
                    }
                    else
                    {
                        report.AppendLine($"  {semantic}: width {width}, PSInput.{name} expects {known.Width}; not copied");
                    }
                }
                else
                {
                    name = "f" + i;
                }

                // Sum of all components (as float), so no interpolator is dropped from the signature.
                if (width == 1)
                {
                    keep.Append("    k += (float)i.").Append(name).Append(";\n");
                }
                else
                {
                    var ft = "float" + width.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    keep.Append("    k += dot((").Append(ft).Append(")i.").Append(name)
                        .Append(", (").Append(ft).Append(")1);\n");
                }

                decl.Append("    ").Append(modifier).Append(type).Append(' ').Append(name)
                    .Append(" : ").Append(hlslSemantic).Append(";\n");
                report.AppendLine($"  r{p.Register} mask {mask:X} {type} {hlslSemantic} -> {name}");
            }
        }

        decl.Append("};\n\n");
        copy.Append("    return o;\n}\n\n");
        keep.Append("    return k;\n}\n");
        return decl.ToString() + copy + keep;
    }

    /// <summary>
    /// Compares the constant buffers our shader shares with Helix's compiled PBR pixel shader.
    /// Same name and size is enforced by Helix; a variable at another offset would read wrong values.
    /// </summary>
    private static void CompareConstantBuffers(byte[] ours, StringBuilder report)
    {
        try
        {
            var theirs = DefaultPSShaderDescriptions.PSMeshPBR.ByteCode;
            if (theirs == null)
            {
                return;
            }

            var a = ReadConstantBuffers(ours);
            var b = ReadConstantBuffers(theirs);
            var mismatches = 0;
            foreach (var (cbName, vars) in a)
            {
                if (!b.TryGetValue(cbName, out var other))
                {
                    continue;
                }

                foreach (var (varName, layout) in vars)
                {
                    if (other.TryGetValue(varName, out var otherLayout) && otherLayout != layout)
                    {
                        mismatches++;
                        report.AppendLine($"  {cbName}.{varName}: offset {layout.Offset}/{layout.Size}, package {otherLayout.Offset}/{otherLayout.Size}");
                    }
                }
            }

            report.AppendLine(mismatches == 0
                ? "Constant buffers match the package's PBR shader"
                : $"{mismatches} constant buffer variables differ from the package");
        }
        catch (Exception ex)
        {
            report.AppendLine("Constant buffer check failed: " + ex.Message);
        }
    }

    /// <summary>Pixel shader input signature as compiled: must line up register by register with the VS output.</summary>
    private static void ReportPixelInputs(byte[] ps, StringBuilder report)
    {
        try
        {
            using var reflection = new D3DC.ShaderReflection(ps);
            var count = reflection.Description.InputParameters;
            report.AppendLine("PS input signature (compiled):");
            for (var i = 0; i < count; i++)
            {
                var p = reflection.GetInputParameterDescription(i);
                report.AppendLine($"  r{p.Register} mask {(int)p.UsageMask & 0xF:X} rw {(int)p.ReadWriteMask & 0xF:X} {p.SemanticName}{p.SemanticIndex}");
            }
        }
        catch (Exception ex)
        {
            report.AppendLine("PS input check failed: " + ex.Message);
        }
    }

    private static Dictionary<string, Dictionary<string, (int Offset, int Size)>> ReadConstantBuffers(byte[] code)
    {
        var result = new Dictionary<string, Dictionary<string, (int Offset, int Size)>>(StringComparer.Ordinal);
        using var reflection = new D3DC.ShaderReflection(code);
        var count = reflection.Description.ConstantBuffers;
        for (var i = 0; i < count; i++)
        {
            var cb = reflection.GetConstantBuffer(i);
            var desc = cb.Description;
            var vars = new Dictionary<string, (int Offset, int Size)>(StringComparer.Ordinal);
            for (var j = 0; j < desc.VariableCount; j++)
            {
                var v = cb.GetVariable(j).Description;
                vars[v.Name] = (v.StartOffset, v.Size);
            }

            result[desc.Name] = vars;
        }

        return result;
    }

    private static string Inline(string source, int depth)
    {
        if (depth > 16)
        {
            throw new InvalidOperationException("HLSL include depth exceeded");
        }

        return s_include.Replace(source, m =>
        {
            var path = m.Groups[1].Value;
            var name = path[(path.LastIndexOfAny(['\\', '/']) + 1)..];
            if (!MultilayerShaderSources.Headers.TryGetValue(name, out var text))
            {
                throw new InvalidOperationException($"HLSL include not found: {path}");
            }

            return Inline(text, depth + 1);
        });
    }
}
