using System;
using System.IO;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class animAnimationBufferCompressed //: IRedAppendix
{
    private const ushort wSignMask = 0x8000;
    private const ushort componentTypeMask = 0x6000;
    private const ushort boneIdxMask = 0x1FFF;
    private const int wSignRightShift = 15;
    private const int componentRightShift = 13;
    private const int boneIdxRightShift = 0;

    [RED("tempBuffer")]
    [REDProperty(IsIgnored = true)]
    public SerializationDeferredDataBuffer TempBuffer
    {
        get => GetPropertyValue<SerializationDeferredDataBuffer>();
        set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
    }

    // Linear interpolation Rotation keyframes,
    // multiple keyframes per joint index.
    [RED("animKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKey> AnimKeys
    {
        get => GetPropertyValue<CArray<animKey>>();
        set => SetPropertyValue<CArray<animKey>>(value);
    }

    // Linear interpolation Translation & Scale keyframes,
    // multiple keyframes per joint index.
    //
    // Non-const rotations are also here if `HasRawRotations=true`
    [RED("animKeysRaw")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKey> AnimKeysRaw
    {
        get => GetPropertyValue<CArray<animKey>>();
        set => SetPropertyValue<CArray<animKey>>(value);
    }

    // Step/const keyframes, may be Translation, Rotation, and/or Scale
    // Single keyframe per joint index, generally both T and R (S rarely seen.)
    //
    // If an index is wholly/partially missing here, it'll be in `AnimKeys*`.
    [RED("constAnimKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKey> ConstAnimKeys
    {
        get => GetPropertyValue<CArray<animKey>>();
        set => SetPropertyValue<CArray<animKey>>(value);
    }

    // Tracks with more than one sample (singles are in ConstTrackKeys)
    [RED("trackKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKeyTrack> TrackKeys
    {
        get => GetPropertyValue<CArray<animKeyTrack>>();
        set => SetPropertyValue<CArray<animKeyTrack>>(value);
    }

    // One per reference track in the rig, missing indices should be in TrackKeys
    [RED("constTrackKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKeyTrack> ConstTrackKeys
    {
        get => GetPropertyValue<CArray<animKeyTrack>>();
        set => SetPropertyValue<CArray<animKeyTrack>>(value);
    }

    public animKey ToAnimKey(float time, ushort idx, ushort component, float x, float y, float z, ushort wSign)
    {
        switch (component)
        {
            case 0:
                return new animKeyPosition()
                {
                    Time = time * Duration,
                    Idx = idx,
                    Position = new Vector3()
                    {
                        X = x,
                        Y = y,
                        Z = z
                    }
                };
            case 1:
                var dotPr = (x * x + y * y + z * z);
                x = x * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                y = y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                z = z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                var w = 1f - dotPr;
                if (wSign == 1)
                {
                    w = -w;
                }
                return new animKeyRotation()
                {
                    Time = time * Duration,
                    Idx = idx,
                    Rotation = new Quaternion()
                    {
                        I = x,
                        J = y,
                        K = z,
                        R = w
                    }
                };
            case 2:
                return new animKeyScale()
                {
                    Time = time * Duration,
                    Idx = idx,
                    Scale = new Vector3()
                    {
                        X = x,
                        Y = y,
                        Z = z
                    }
                };
            default:
                return null;
        }
    }

    public (ushort component, float x, float y, float z, bool wSign) FromAnimKey(animKey animKey)
    {
        if (animKey is animKeyPosition p)
        {
            return (0, p.Position.X, p.Position.Y, p.Position.Z, false);
        }
        else if (animKey is animKeyRotation r)
        {
            bool wSign = r.Rotation.R < 0;

            float w = wSign ? -r.Rotation.R : r.Rotation.R;

            float dotPr = 1f - w;

            float x = r.Rotation.I / Convert.ToSingle(Math.Sqrt(2f - dotPr));
            float y = r.Rotation.J / Convert.ToSingle(Math.Sqrt(2f - dotPr));
            float z = r.Rotation.K / Convert.ToSingle(Math.Sqrt(2f - dotPr));

            return (1, x, y, z, wSign);
        }
        else if (animKey is animKeyScale s)
        {
            return (2, s.Scale.X, s.Scale.Y, s.Scale.Z, false);
        }
        else
        {
            return (0, 0, 0, 0, false);
        }
    }

    internal static Func<UInt16, float> DequantU16toF32 = (ui16) => ((1f / 65535f) * ui16 * 2) - 1f;
    internal static Func<float, UInt16> QuantizeF32toU16 = (f32) => Convert.ToUInt16((f32 + 1) / 2 * (65535));

    public void ReadBuffer()
    {
        MemoryStream defferedBuffer = null;
        if (InplaceCompressedBuffer != null)
        {
            var tmpBytes = InplaceCompressedBuffer.Buffer.GetBytes();
            var real_memsize = 0u;
            if (Oodle.IsCompressed(tmpBytes))
            {
                real_memsize = BitConverter.ToUInt32( tmpBytes, 4 );
                Oodle.DecompressBuffer(tmpBytes, out var raw);
                tmpBytes = raw;
                if (Oodle.IsCompressed(tmpBytes))
                {
                    real_memsize = BitConverter.ToUInt32( tmpBytes, 4 );
                    Oodle.DecompressBuffer(tmpBytes, out var realraw);
                    tmpBytes = realraw;
                }
            }
            defferedBuffer = new MemoryStream(tmpBytes);
        }
        else if (DefferedBuffer != null)
        {
            defferedBuffer = new MemoryStream(DefferedBuffer.Buffer.GetBytes());
        }
        else if (TempBuffer != null)
        {
            defferedBuffer = new MemoryStream(TempBuffer.Buffer.GetBytes());
        }

        if (defferedBuffer == null)
            return;

        defferedBuffer.Seek(0, SeekOrigin.Begin);

        var br = new BinaryReader(defferedBuffer);

        AnimKeys = new();
        for (uint i = 0; i < NumAnimKeys; i++)
        {
            // NB different time, idx order to ConstAnimKeys
            var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
            var bitWiseData = br.ReadUInt16();
            var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
            var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
            var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);
            var x = DequantU16toF32(br.ReadUInt16());
            var y = DequantU16toF32(br.ReadUInt16());
            var z = DequantU16toF32(br.ReadUInt16());
            AnimKeys.Add(ToAnimKey(timeNormalized, boneIdx, component, x, y, z, wSign));
        }

        AnimKeysRaw = new();
        for (uint i = 0; i < NumAnimKeysRaw; i++)
        {
            // NB different time, idx order to ConstAnimKeys
            var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
            var bitWiseData = br.ReadUInt16();
            var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
            var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
            var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

            var x = br.ReadSingle();
            var y = br.ReadSingle();
            var z = br.ReadSingle();

            AnimKeysRaw.Add(ToAnimKey(timeNormalized, boneIdx, component, x, y, z, wSign));
        }

        ConstAnimKeys = new();
        for (uint i = 0; i < NumConstAnimKeys; i++)
        { 
            // NB different idx, time order to AnimKeys*
            var bitWiseData = br.ReadUInt16();
            var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
            var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
            var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
            var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

            var x = br.ReadSingle();
            var y = br.ReadSingle();
            var z = br.ReadSingle();

            ConstAnimKeys.Add(ToAnimKey(timeNormalized, boneIdx, component, x, y, z, wSign));
        }

        TrackKeys = new();
        for (uint i = 0; i < NumTrackKeys; i++)
        {
            // NB different time, idx order to ConstTrackKeys
            var time = br.ReadUInt16() / (float)ushort.MaxValue;
            var idx = br.ReadUInt16();
            float value = br.ReadSingle();
            TrackKeys.Add(new animKeyTrack()
            {
                TrackIndex = idx,
                Time = time * Duration,
                Value = value,
            });
        }

        ConstTrackKeys = new();
        for (uint i = 0; i < NumConstTrackKeys; i++)
        {
            // NB different idx, time order to TrackKeys
            var idx = br.ReadUInt16();
            var time = br.ReadUInt16() / (float)ushort.MaxValue;
            float value = br.ReadSingle();
            ConstTrackKeys.Add(new animKeyTrack()
            {
                TrackIndex = idx,
                Time = time * Duration,
                Value = value,
            });
        }
    }

    public void WriteBuffer()
    {
        MemoryStream defferedBuffer = new MemoryStream();
        //defferedBuffer.Seek(0, SeekOrigin.Begin);

        var bw = new BinaryWriter(defferedBuffer);

        for (int i = 0; i < AnimKeys.Count; i++)
        {
            // NB order of time, idx is different to ConstAnimKeys
            bw.Write((ushort)(AnimKeys[i].Time / Duration * ushort.MaxValue));

            var bitWiseData = 0;
            var (component, x, y, z, wSign) = FromAnimKey(AnimKeys[i]);
            bitWiseData |= (wSign ? 1 : 0) << wSignRightShift;
            bitWiseData |= component << componentRightShift;
            bitWiseData |= AnimKeys[i].Idx;
            bw.Write((ushort)bitWiseData);

            bw.Write(QuantizeF32toU16(x));
            bw.Write(QuantizeF32toU16(y));
            bw.Write(QuantizeF32toU16(z));
        }

        for (int i = 0; i < AnimKeysRaw.Count; i++)
        {
            // NB order of time, idx is different to ConstAnimKeys
            bw.Write((ushort)(AnimKeysRaw[i].Time / Duration * ushort.MaxValue));

            var bitWiseData = 0;
            var (component, x, y, z, wSign) = FromAnimKey(AnimKeysRaw[i]);
            bitWiseData |= (wSign ? 1 : 0) << wSignRightShift;
            bitWiseData |= component << componentRightShift;
            bitWiseData |= AnimKeysRaw[i].Idx;
            bw.Write((ushort)bitWiseData);

            bw.Write((float)x);
            bw.Write((float)y);
            bw.Write((float)z);
        }

        for (int i = 0; i < ConstAnimKeys.Count; i++)
        {
            // NB order of idx, time is different to AnimKeys*
            var bitWiseData = 0;
            var (component, x, y, z, wSign) = FromAnimKey(ConstAnimKeys[i]);
            bitWiseData |= (wSign ? 1 : 0) << wSignRightShift;
            bitWiseData |= component << componentRightShift;
            bitWiseData |= ConstAnimKeys[i].Idx;
            bw.Write((ushort)bitWiseData);
            bw.Write((ushort)(ConstAnimKeys[i].Time / Duration * ushort.MaxValue));

            bw.Write((float)x);
            bw.Write((float)y);
            bw.Write((float)z);
        }

        for (int i = 0; i < TrackKeys.Count; i++)
        {
            // NB different time, idx order to ConstTrackKeys
            bw.Write((ushort)(TrackKeys[i].Time / Duration * ushort.MaxValue));
            bw.Write(TrackKeys[i].TrackIndex);
            bw.Write((float)TrackKeys[i].Value);
        }

        for (int i = 0; i < ConstTrackKeys.Count; i++)
        {
            // NB different idx, time order to TrackKeys
            bw.Write(ConstTrackKeys[i].TrackIndex);
            bw.Write((ushort)(ConstTrackKeys[i].Time / Duration * ushort.MaxValue));
            bw.Write((float)ConstTrackKeys[i].Value);
        }

        TempBuffer.Buffer.SetBytes(defferedBuffer.ToByteArray());
    }
}

public abstract class animKey : RedBaseClass
{
    [RED("timeNormalized")]
    [REDProperty(IsIgnored = true)]
    public CFloat Time
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("idx")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Idx
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }
}

public class animKeyPosition : animKey
{
    [RED("position")]
    [REDProperty(IsIgnored = true)]
    public Vector3 Position
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }
}

public class animKeyRotation : animKey
{ 
    [RED("rotation")]
    [REDProperty(IsIgnored = true)]
    public Quaternion Rotation
    {
        get => GetPropertyValue<Quaternion>();
        set => SetPropertyValue<Quaternion>(value);
    }
}

public class animKeyScale : animKey
{
    [RED("scale")]
    [REDProperty(IsIgnored = true)]
    public Vector3 Scale
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }
}

public class animKeyFloat : animKey
{
    [RED("value")]
    [REDProperty(IsIgnored = true)]
    public CFloat Value
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}

public class animKeyTrack : RedBaseClass
{
    [RED("timeNormalized")]
    [REDProperty(IsIgnored = true)]
    public CFloat Time
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("idx")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 TrackIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("value")]
    [REDProperty(IsIgnored = true)]
    public CFloat Value
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}
