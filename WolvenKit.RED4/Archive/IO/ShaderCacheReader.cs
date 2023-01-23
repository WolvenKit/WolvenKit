using System.Diagnostics;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Shaders;

namespace WolvenKit.RED4.Archive.IO;

public class ShaderCacheReader
{
    // new FileInfo(_settingsManager.CP77ExecutablePath)

    public static void ExtractShaders(FileInfo executable, string exportPath)
    {
        var di = executable.Directory;
        if (di?.Parent?.Parent is null)
        {
            return;
        }
        if (!di.Exists)
        {
            return;
        }

        if (!Directory.Exists(exportPath))
        {
            return;
        }

        var shaderDirectory = Path.Combine(exportPath, "shaders");

        if (!Directory.Exists(shaderDirectory))
        {
            Directory.CreateDirectory(shaderDirectory);
        }

        var shaderCache = Path.Combine(di.Parent.Parent.FullName, "engine", "shader_final.cache");

        var fh = File.OpenRead(shaderCache);
        var br = new BinaryReader(fh);

        br.BaseStream.Seek(-0x70, SeekOrigin.End);

        var footer = br.BaseStream.ReadStruct<ShaderCacheFooter>();

        var paramSets = new Dictionary<ulong, ParameterSet>();
        var shaders = new Dictionary<ulong, Shader>();
        var extras = new List<Extra>();
        var shaderMappings = new List<ShaderMapping>();
        var effects = new Dictionary<ulong, string>();
        var materialTemplates = new Dictionary<string, List<Extra>>();

        // Parameter Sets
        br.BaseStream.Seek((long)footer.notherOffset, SeekOrigin.Begin);
        for (int i = 0; i < footer.notherCount; i++)
        {
            var guid = br.ReadUInt64();
            var uk1 = br.ReadUInt32();
            var paramCount = br.ReadUInt32();

            var paramList = new List<Parameter>();
            for (int j = 0; j < paramCount; j++)
            {
                var name_length = br.ReadByte();
                var name = br.ReadChars(name_length & 0b01111111);
                var puk1 = br.ReadByte();
                var puk2 = br.ReadByte();
                var p = new Parameter()
                {
                    Name = new string(name),
                    uk1 = puk1,
                    uk2 = puk2
                };
                paramList.Add(p);
            }

            paramSets.Add(guid, new ParameterSet()
            {
                GUID = guid,
                uk1 = uk1,
                Parameters = paramList
            });
        }

        // Shaders (compiled HLSL)
        // for more info on the shader format:
        // https://vodacek.zvb.cz/archiv/617.html
        br.BaseStream.Seek(0, SeekOrigin.Begin);
        for (int i = 0; i < footer.shaderCount; i++)
        {
            var shaderHeader = br.BaseStream.ReadStruct<ShaderCacheShader>();
            var shader = br.ReadBytes((int)shaderHeader.shaderSize);
            var shaderFile = Path.Combine(shaderDirectory, $"{shaderHeader.GUID}.compiled_hlsl");
            ParameterSet p = null;
            if (paramSets.ContainsKey(shaderHeader.paramsGUID))
            {
                p = paramSets[shaderHeader.paramsGUID];
            }

            shaders.Add(shaderHeader.GUID, new Shader()
            {
                GUID = shaderHeader.GUID,
                ParamsGUID = shaderHeader.paramsGUID,
                FileName = shaderFile,
                Size = shaderHeader.shaderSize,
                Parameters = p
            });

            if (!File.Exists(shaderFile))
            {
                var shaderFS = File.Open(shaderFile, FileMode.Create);
                shaderFS.Write(shader);
                shaderFS.DisposeAsync();
            }
        }

        // Shader compilation info
        br.BaseStream.Seek((long)footer.extraOffset, SeekOrigin.Begin);
        for (int i = 0; i < footer.extraCount; i++)
        {
            // might be some sort of id or type
            var startThing = br.ReadUInt32();
            var endThing = br.ReadUInt32();
            // probably additional flags stored in these variables
            var strLength1 = br.ReadByte();
            var strLength2 = br.ReadByte();
            var shaderInfo = new string(br.ReadChars((strLength1 & 0b10111111) | ((strLength2 & 0b00000001) << 6)));
            var templateName = shaderInfo.Split(" ")[0];

            var startThing2 = br.ReadUInt32();
            Debug.Assert(startThing == startThing2);

            var shaderGUID = br.ReadUInt64();
            Shader pixelShader = null;
            if (shaders.ContainsKey(shaderGUID))
            {
                pixelShader = shaders[shaderGUID];
            }

            shaderGUID = br.ReadUInt64();
            Shader vertexShader = null;
            if (shaders.ContainsKey(shaderGUID))
            {
                vertexShader = shaders[shaderGUID];
            }

            var materialGUID1 = br.ReadUInt64();
            var materialGUID2 = br.ReadUInt64();
            Debug.Assert(materialGUID1 == materialGUID2);

            var uk1 = br.ReadUInt64();

            var endThing2 = br.ReadUInt32();
            Debug.Assert(endThing == endThing2);

            var flag1Count = br.ReadUInt32();
            var flag1List = new List<ulong>();
            for (int j = 0; j < flag1Count; j++)
            {
                flag1List.Add(br.ReadUInt64());
            }

            var flag2Count = br.ReadUInt32();
            var flag2List = new List<ulong>();
            for (int j = 0; j < flag2Count; j++)
            {
                flag2List.Add(br.ReadUInt64());
            }

            var extra = new Extra()
            {
                TemplateName = templateName,
                StartThing = startThing,
                EndThing = endThing,
                ShaderInfo = shaderInfo,
                PixelShader = pixelShader,
                VertexShader = vertexShader,
                MaterialGUID = materialGUID1,
                uk1 = uk1,
                Flags1 = flag1List,
                Flags2 = flag2List
            };

            if (!materialTemplates.ContainsKey(templateName))
            {
                materialTemplates[templateName] = new List<Extra>();
            }
            materialTemplates[templateName].Add(extra);

            extras.Add(extra);
        }

        // Shader mapping of some sort
        br.BaseStream.Seek((long)footer.onemoreOffset, SeekOrigin.Begin);
        var mappingCount = br.ReadUInt32();
        for (int i = 0; i < mappingCount; i++)
        {
            shaderMappings.Add(new ShaderMapping()
            {
                EndThing = br.ReadUInt32(),
                ID = br.ReadUInt32(),
                Postfix = br.ReadUInt32()
            });
        }

        // FX strings & guids
        br.BaseStream.Seek((long)footer.struct2Offset, SeekOrigin.Begin);
        var effectCount = br.ReadUInt32();
        for (int i = 0; i < effectCount; i++)
        {
            var name_length = br.ReadByte();
            var name = br.ReadChars(name_length & 0b01111111);
            var guid = br.ReadUInt64();
            effects.Add(guid, new string(name));
        }

        // breakpoint here
        return;
    }
}