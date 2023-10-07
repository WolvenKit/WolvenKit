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

    [RED("animKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKey> AnimKeys
    {
        get => GetPropertyValue<CArray<animKey>>();
        set => SetPropertyValue<CArray<animKey>>(value);
    }

    [RED("animKeysRaw")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKey> AnimKeysRaw
    {
        get => GetPropertyValue<CArray<animKey>>();
        set => SetPropertyValue<CArray<animKey>>(value);
    }

    [RED("constAnimKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKey> ConstAnimKeys
    {
        get => GetPropertyValue<CArray<animKey>>();
        set => SetPropertyValue<CArray<animKey>>(value);
    }

    [RED("trackKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKeyFloat> TrackKeys
    {
        get => GetPropertyValue<CArray<animKeyFloat>>();
        set => SetPropertyValue<CArray<animKeyFloat>>(value);
    }

    [RED("constTrackKeys")]
    [REDProperty(IsIgnored = true)]
    public CArray<animKeyFloat> ConstTrackKeys
    {
        get => GetPropertyValue<CArray<animKeyFloat>>();
        set => SetPropertyValue<CArray<animKeyFloat>>(value);
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
            var x = r.Rotation.I;
            var y = r.Rotation.J;
            var z = r.Rotation.K;
            var wSign = r.Rotation.R > 0;
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

    public void ReadBuffer()
    {
        MemoryStream defferedBuffer = null;
        if (InplaceCompressedBuffer != null)
        {
            var tmpBytes = InplaceCompressedBuffer.Buffer.GetBytes();
            if (Oodle.IsCompressed(tmpBytes))
            {
                Oodle.DecompressBuffer(tmpBytes, out var raw);
                tmpBytes = raw;
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
            var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
            var bitWiseData = br.ReadUInt16();
            var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
            var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
            var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

            var x = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;
            var y = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;
            var z = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;

            AnimKeys.Add(ToAnimKey(timeNormalized, boneIdx, component, x, y, z, wSign));
        }

        AnimKeysRaw = new();
        for (uint i = 0; i < NumAnimKeysRaw; i++)
        {
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
            var idx = br.ReadUInt16();
            var time = br.ReadUInt16() / (float)ushort.MaxValue; //is it time or some garbage idk
            float value = br.ReadSingle();
            TrackKeys.Add(new animKeyFloat()
            {
                Idx = idx,
                Time = time,
                Value = value,
            });
        }

        ConstTrackKeys = new();
        for (uint i = 0; i < NumConstTrackKeys; i++)
        {
            var idx = br.ReadUInt16();
            var time = br.ReadUInt16() / (float)ushort.MaxValue; //is it time or some garbage idk
            float value = br.ReadSingle();
            ConstTrackKeys.Add(new animKeyFloat()
            {
                Idx = idx,
                Time = time,
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
            bw.Write((ushort)(AnimKeys[i].Time * ushort.MaxValue));

            var bitWiseData = 0;
            var (component, x, y, z, wSign) = FromAnimKey(AnimKeys[i]);
            bitWiseData |= (wSign ? 1 : 0) << wSignRightShift;
            bitWiseData |= component << componentRightShift;
            bitWiseData |= AnimKeys[i].Idx;
            bw.Write((ushort)bitWiseData);

            bw.Write((ushort)((x + 1) / 2 * (65535)));
            bw.Write((ushort)((y + 1) / 2 * (65535)));
            bw.Write((ushort)((z + 1) / 2 * (65535)));
        }

        for (int i = 0; i < AnimKeysRaw.Count; i++)
        {
            bw.Write((ushort)(AnimKeys[i].Time * ushort.MaxValue));

            var bitWiseData = 0;
            var (component, x, y, z, wSign) = FromAnimKey(AnimKeys[i]);
            bitWiseData |= (wSign ? 1 : 0) << wSignRightShift;
            bitWiseData |= component << componentRightShift;
            bitWiseData |= AnimKeys[i].Idx;
            bw.Write((ushort)bitWiseData);

            bw.Write((float)x);
            bw.Write((float)y);
            bw.Write((float)z);
        }

        for (int i = 0; i < ConstAnimKeys.Count; i++)
        {

            var bitWiseData = 0;
            var (component, x, y, z, wSign) = FromAnimKey(AnimKeys[i]);
            bitWiseData |= (wSign ? 1 : 0) << wSignRightShift;
            bitWiseData |= component << componentRightShift;
            bitWiseData |= AnimKeys[i].Idx;
            bw.Write((ushort)bitWiseData);
            bw.Write((ushort)(AnimKeys[i].Time * ushort.MaxValue));

            bw.Write((float)x);
            bw.Write((float)y);
            bw.Write((float)z);
        }

        for (int i = 0; i < TrackKeys.Count; i++)
        {
            bw.Write(TrackKeys[i].Idx);
            bw.Write((ushort)(TrackKeys[i].Time * ushort.MaxValue));
            bw.Write((float)TrackKeys[i].Value);
        }

        for (int i = 0; i < ConstTrackKeys.Count; i++)
        {
            bw.Write(ConstTrackKeys[i].Idx);
            bw.Write((ushort)(ConstTrackKeys[i].Time * ushort.MaxValue));
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