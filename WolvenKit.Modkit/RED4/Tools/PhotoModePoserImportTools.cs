using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

using NumericsQuaternion = System.Numerics.Quaternion;
using NumericsVector3 = System.Numerics.Vector3;

namespace WolvenKit.Modkit.RED4.Tools;

public sealed record PhotoModePoserImportResult(string RigPath, string OutputPath, int PoseCount);

/// <summary>
/// Converts PhotoMode Poser pose-pack JSON files into static REDengine animation sets.
/// </summary>
public sealed class PhotoModePoserImportTools
{
    private const float s_duration = 1.0f / 24.0f;
    private const string s_packKind = "PhotoModePoser.posePack";

    private static readonly JsonSerializerOptions s_jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true
    };

    private readonly ILoggerService _loggerService;

    public PhotoModePoserImportTools(ILoggerService loggerService) => _loggerService = loggerService;

    public IReadOnlyList<PhotoModePoserImportResult> Import(FileInfo posePackFile, DirectoryInfo outputDirectory)
    {
        ArgumentNullException.ThrowIfNull(posePackFile);
        ArgumentNullException.ThrowIfNull(outputDirectory);

        if (!posePackFile.Exists)
        {
            throw new FileNotFoundException("PhotoMode Poser pose pack was not found.", posePackFile.FullName);
        }

        var pack = ReadPack(posePackFile);
        var groups = ValidateAndGroup(pack, posePackFile.Name);
        Directory.CreateDirectory(outputDirectory.FullName);

        var outputNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var results = new List<PhotoModePoserImportResult>(groups.Count);
        foreach (var group in groups)
        {
            var outputName = MakeOutputName(posePackFile, group.RigPath, outputNames);
            var outputPath = Path.Combine(outputDirectory.FullName, outputName);
            WriteAnimSet(group, outputPath);

            _loggerService.Success($"Imported {group.Poses.Count} PhotoMode Poser pose(s) for {group.RigPath} to {outputPath}");
            results.Add(new PhotoModePoserImportResult(group.RigPath, outputPath, group.Poses.Count));
        }

        return results;
    }

    private static PosePack ReadPack(FileInfo posePackFile)
    {
        using var stream = posePackFile.OpenRead();
        var pack = JsonSerializer.Deserialize<PosePack>(stream, s_jsonOptions)
                   ?? throw new InvalidDataException($"{posePackFile.Name}: file contains no pose-pack data.");

        if (!string.Equals(pack.Kind, s_packKind, StringComparison.Ordinal))
        {
            throw new InvalidDataException($"{posePackFile.Name}: expected kind '{s_packKind}', found '{pack.Kind ?? "<missing>"}'.");
        }

        if (pack.Poses.Count == 0)
        {
            throw new InvalidDataException($"{posePackFile.Name}: pose pack contains no poses.");
        }

        return pack;
    }

    private static List<RigPoseGroup> ValidateAndGroup(PosePack pack, string sourceName)
    {
        var groups = new Dictionary<string, RigPoseGroup>(StringComparer.OrdinalIgnoreCase);
        foreach (var pose in pack.Poses)
        {
            var poseLabel = pose.Name ?? pose.Id ?? "<unnamed pose>";
            var rigPath = pose.TargetRig?.RigPath?.Trim();
            if (string.IsNullOrWhiteSpace(rigPath))
            {
                throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' has no targetRig.rigPath.");
            }

            if (pose.TargetRig!.BoneCount is < 1 or > ushort.MaxValue)
            {
                throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' has invalid targetRig.boneCount {pose.TargetRig.BoneCount}.");
            }

            ValidatePoseTransforms(pose, poseLabel, sourceName);

            if (!groups.TryGetValue(rigPath, out var group))
            {
                group = new RigPoseGroup(rigPath, pose.TargetRig.BoneCount, BuildBoneMap(pose));
                groups.Add(rigPath, group);
            }
            else
            {
                ValidateAgainstGroup(pose, poseLabel, group, sourceName);
            }

            group.Poses.Add(pose);
        }

        foreach (var group in groups.Values)
        {
            var names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var pose in group.Poses)
            {
                var name = GetAnimationName(pose);
                if (!names.Add(name))
                {
                    throw new InvalidDataException($"{sourceName}: rig '{group.RigPath}' contains duplicate animation name '{name}'.");
                }
            }
        }

        return groups.Values.ToList();
    }

    private static void ValidatePoseTransforms(Pose pose, string poseLabel, string sourceName)
    {
        var boneCount = pose.TargetRig!.BoneCount;
        if (pose.Transforms.Count != boneCount)
        {
            throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' declares {boneCount} bones but contains {pose.Transforms.Count} transforms.");
        }

        var seen = new bool[boneCount];
        foreach (var transform in pose.Transforms)
        {
            if (transform.Index < 0 || transform.Index >= boneCount)
            {
                throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' has out-of-range bone index {transform.Index}.");
            }

            if (seen[transform.Index])
            {
                throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' contains bone index {transform.Index} more than once.");
            }

            if (string.IsNullOrWhiteSpace(transform.Bone))
            {
                throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' has no bone name at index {transform.Index}.");
            }

            ValidateFinite(transform, poseLabel, sourceName);
            seen[transform.Index] = true;
        }

        if (seen.Any(value => !value))
        {
            throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' does not contain a contiguous transform for every declared bone.");
        }
    }

    private static void ValidateFinite(PoseTransform transform, string poseLabel, string sourceName)
    {
        var values = new[]
        {
            transform.Translation.X, transform.Translation.Y, transform.Translation.Z,
            transform.Rotation.I, transform.Rotation.J, transform.Rotation.K, transform.Rotation.R,
            transform.Scale.X, transform.Scale.Y, transform.Scale.Z
        };
        if (values.Any(value => !float.IsFinite(value)))
        {
            throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' contains a non-finite transform for '{transform.Bone}'.");
        }

        var rotationLengthSquared = transform.Rotation.I * transform.Rotation.I
                                    + transform.Rotation.J * transform.Rotation.J
                                    + transform.Rotation.K * transform.Rotation.K
                                    + transform.Rotation.R * transform.Rotation.R;
        if (rotationLengthSquared < 0.000001f)
        {
            throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' contains a zero-length rotation for '{transform.Bone}'.");
        }
    }

    private static string[] BuildBoneMap(Pose pose) => pose.Transforms
        .OrderBy(transform => transform.Index)
        .Select(transform => transform.Bone!)
        .ToArray();

    private static void ValidateAgainstGroup(Pose pose, string poseLabel, RigPoseGroup group, string sourceName)
    {
        if (pose.TargetRig!.BoneCount != group.BoneCount)
        {
            throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' has {pose.TargetRig.BoneCount} bones, but rig group '{group.RigPath}' expects {group.BoneCount}.");
        }

        foreach (var transform in pose.Transforms)
        {
            if (!string.Equals(transform.Bone, group.BoneNames[transform.Index], StringComparison.Ordinal))
            {
                throw new InvalidDataException($"{sourceName}: pose '{poseLabel}' maps index {transform.Index} to '{transform.Bone}', but rig group '{group.RigPath}' maps it to '{group.BoneNames[transform.Index]}'.");
            }
        }
    }

    private void WriteAnimSet(RigPoseGroup group, string outputPath)
    {
        var animSet = new animAnimSet
        {
            Rig = new CResourceReference<animRig>((ResourcePath)group.RigPath),
            FallbackAnimDataBuffer = new DataBuffer(),
            Version = 0
        };

        foreach (var pose in group.Poses)
        {
            var animationData = BuildAnimationData(pose, group.BoneCount);
            var dataAddress = new animAnimDataAddress
            {
                UnkIndex = (uint)animSet.AnimationDataChunks.Count,
                FsetInBytes = 0,
                ZeInBytes = 0
            };

            CompressedBuffer.EncodeAnimationData(
                out var dataChunk,
                out var animationBuffer,
                in animationData,
                dataAddress,
                _loggerService);

            var animation = new animAnimation
            {
                Name = GetAnimationName(pose),
                Duration = s_duration,
                AnimationType = animAnimationType.Normal,
                AnimBuffer = new CHandle<animIAnimationBuffer>(animationBuffer),
                FrameClamping = true,
                FrameClampingStartFrame = -1,
                FrameClampingEndFrame = -1
            };

            animSet.AnimationDataChunks.Add(dataChunk);
            animSet.Animations.Add(new CHandle<animAnimSetEntry>(new animAnimSetEntry
            {
                Animation = new CHandle<animAnimation>(animation),
                Events = new CHandle<animEventsContainer>()
            }));
        }

        var file = new CR2WFile { RootChunk = animSet };
        using var stream = File.Create(outputPath);
        using var writer = new CR2WWriter(stream, Encoding.UTF8, true) { LoggerService = _loggerService };
        writer.WriteFile(file);
    }

    private static AnimationBufferData BuildAnimationData(Pose pose, int boneCount)
    {
        var translations = new Dictionary<ushort, Dictionary<float, NumericsVector3>>(boneCount);
        var rotations = new Dictionary<ushort, Dictionary<float, NumericsQuaternion>>(boneCount);
        var scales = new Dictionary<ushort, Dictionary<float, NumericsVector3>>(boneCount);

        foreach (var transform in pose.Transforms)
        {
            var index = checked((ushort)transform.Index);

            // The encoder accepts glTF-space values and performs the final conversion to RED space.
            translations[index] = new Dictionary<float, NumericsVector3>
            {
                [0.0f] = new NumericsVector3(transform.Translation.X, transform.Translation.Z, -transform.Translation.Y)
            };

            var rotation = NumericsQuaternion.Normalize(new NumericsQuaternion(
                transform.Rotation.I,
                transform.Rotation.K,
                -transform.Rotation.J,
                transform.Rotation.R));
            rotations[index] = new Dictionary<float, NumericsQuaternion> { [0.0f] = rotation };

            scales[index] = new Dictionary<float, NumericsVector3>
            {
                [0.0f] = new NumericsVector3(transform.Scale.X, transform.Scale.Z, transform.Scale.Y)
            };
        }

        return new AnimationBufferData
        {
            Duration = s_duration,
            FrameCount = 2,
            Translations = [],
            ConstTranslations = translations,
            Rotations = [],
            ConstRotations = rotations,
            Scales = [],
            ConstScales = scales,
            TrackKeys = [],
            ConstTrackKeys = [],
            FallbackFrameIndices = [],
            NumJoints = checked((ushort)boneCount),
            NumExtraJoints = 0,
            JointsCountActual = checked((ushort)boneCount),
            NumTracks = 0,
            NumExtraTracks = 0,
            TracksCountActual = 0,
            IsSimd = false,
            CompressionUsed = AnimationCompression.QuaternionAsFixed3x16bit,
            SimdQuantizationBits = 0
        };
    }

    private static string GetAnimationName(Pose pose)
    {
        var name = string.IsNullOrWhiteSpace(pose.Id) ? pose.Name : pose.Id;
        return name?.Trim() ?? throw new InvalidDataException("Pose has neither an id nor a name.");
    }

    private static string MakeOutputName(FileInfo posePackFile, string rigPath, HashSet<string> usedNames)
    {
        var packName = SanitizeFileName(Path.GetFileNameWithoutExtension(posePackFile.Name));
        var rigName = SanitizeFileName(Path.GetFileNameWithoutExtension(rigPath.Replace('\\', Path.DirectorySeparatorChar)));
        var stem = $"{packName}__{rigName}";
        var candidate = $"{stem}.anims";
        var suffix = 2;
        while (!usedNames.Add(candidate))
        {
            candidate = $"{stem}_{suffix++}.anims";
        }

        return candidate;
    }

    private static string SanitizeFileName(string value)
    {
        var invalid = Path.GetInvalidFileNameChars();
        var characters = value.Select(character => invalid.Contains(character) ? '_' : character).ToArray();
        return new string(characters).Trim();
    }

    private sealed class RigPoseGroup
    {
        public RigPoseGroup(string rigPath, int boneCount, string[] boneNames)
        {
            RigPath = rigPath;
            BoneCount = boneCount;
            BoneNames = boneNames;
        }

        public string RigPath { get; }
        public int BoneCount { get; }
        public string[] BoneNames { get; }
        public List<Pose> Poses { get; } = [];
    }

    private sealed class PosePack
    {
        public string? Kind { get; set; }
        public int Version { get; set; }
        public List<Pose> Poses { get; set; } = [];
    }

    private sealed class Pose
    {
        public string? Name { get; set; }
        public string? Id { get; set; }
        public TargetRig? TargetRig { get; set; }
        public List<PoseTransform> Transforms { get; set; } = [];
    }

    private sealed class TargetRig
    {
        public string? RigPath { get; set; }
        public int BoneCount { get; set; }
    }

    private sealed class PoseTransform
    {
        public int Index { get; set; }
        public string? Bone { get; set; }
        public PoseVector Translation { get; set; } = new();
        public PoseQuaternion Rotation { get; set; } = new();
        public PoseVector Scale { get; set; } = new();
    }

    private sealed class PoseVector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        [JsonPropertyName("w")]
        public float W { get; set; }
    }

    private sealed class PoseQuaternion
    {
        public float I { get; set; }
        public float J { get; set; }
        public float K { get; set; }
        public float R { get; set; }
    }
}
