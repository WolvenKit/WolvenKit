using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCompiledEffectInfo : IRedCompiledPropertyData
{
    public bool IsCustomReadNeeded(RedPackageHeader redPackageHeader) => redPackageHeader.unk1 == 2;

    public IRedType? CustomRead(Red4Reader reader, uint size, CName propertyName)
    {
        IRedType? result = null;

        if (propertyName == "placementTags")
        {
            var tmp = new CArray<CName>();

            var cnt = reader.BaseReader.ReadInt32();
            for (var i = 0; i < cnt; i++)
            {
                tmp.Add(reader.ReadCName());
            }

            result = tmp;
        }

        if (propertyName == "componentNames")
        {
            var tmp = new CArray<CName>();

            var cnt = reader.BaseReader.ReadInt32();
            for (var i = 0; i < cnt; i++)
            {
                tmp.Add(reader.ReadCName());
            }

            result = tmp;
        }

        if (propertyName == "relativePositions")
        {
            var tmp = new CArray<Vector3>();

            var cnt = reader.BaseReader.ReadInt32();
            for (var i = 0; i < cnt; i++)
            {
                tmp.Add(new Vector3
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat(),
                    Z = reader.ReadCFloat()
                });
            }

            result = tmp;
        }

        if (propertyName == "relativeRotations")
        {
            var tmp = new CArray<Quaternion>();

            var cnt = reader.BaseReader.ReadInt32();
            for (var i = 0; i < cnt; i++)
            {
                tmp.Add(new Quaternion
                {
                    I = reader.ReadCFloat(),
                    J = reader.ReadCFloat(),
                    K = reader.ReadCFloat(),
                    R = reader.ReadCFloat()
                });
            }

            result = tmp;
        }

        if (propertyName == "placementInfos")
        {
            var tmp = new CArray<worldCompiledEffectPlacementInfo>();

            var cnt = reader.BaseReader.ReadInt32();
            for (var i = 0; i < cnt; i++)
            {
                tmp.Add(new worldCompiledEffectPlacementInfo
                {
                    PlacementTagIndex = reader.ReadCUInt8(),
                    RelativePositionIndex = reader.ReadCUInt8(),
                    RelativeRotationIndex = reader.ReadCUInt8(),
                    Flags = reader.ReadCUInt8()
                });
            }

            result = tmp;
        }

        if (propertyName == "eventsSortedByRUID")
        {
            var tmp = new CArray<worldCompiledEffectEventInfo>();

            var cnt = reader.BaseReader.ReadInt32();
            for (var i = 0; i < cnt; i++)
            {
                tmp.Add(new worldCompiledEffectEventInfo
                {
                    EventRUID = reader.ReadCRUID(),
                    PlacementIndexMask = reader.ReadCUInt64(),
                    ComponentIndexMask = reader.ReadCUInt64(),
                    Flags = reader.ReadCUInt8()
                });

                // TODO: [Patch-2.0] Find out what this is
                // Always 0?
                reader.BaseReader.ReadBytes(7);
            }

            result = tmp;
        }

        return result;
    }

    public bool IsCustomWriteNeeded(RedPackageHeader redPackageHeader) => redPackageHeader.unk1 == 2;

    public void CustomWrite(Red4Writer writer, CName propertyName)
    {
        if (propertyName == "placementTags")
        {
            if (PlacementTags == null)
            {
                return;
            }

            writer.BaseWriter.Write(PlacementTags.Count);
            foreach (var placementTag in PlacementTags)
            {
                writer.Write(placementTag);
            }
        }

        if (propertyName == "componentNames")
        {
            if (ComponentNames == null)
            {
                return;
            }

            writer.BaseWriter.Write(ComponentNames.Count);
            foreach (var componentName in ComponentNames)
            {
                writer.Write(componentName);
            }
        }

        if (propertyName == "relativePositions")
        {
            if (RelativePositions == null)
            {
                return;
            }

            writer.BaseWriter.Write(RelativePositions.Count);
            foreach (var relativePosition in RelativePositions)
            {
                writer.Write(relativePosition.X);
                writer.Write(relativePosition.Y);
                writer.Write(relativePosition.Z);
            }
        }

        if (propertyName == "relativeRotations")
        {
            if (RelativeRotations == null)
            {
                return;
            }

            writer.BaseWriter.Write(RelativeRotations.Count);
            foreach (var relativeRotation in RelativeRotations)
            {
                writer.Write(relativeRotation.I);
                writer.Write(relativeRotation.J);
                writer.Write(relativeRotation.K);
                writer.Write(relativeRotation.R);
            }
        }

        if (propertyName == "placementInfos")
        {
            if (PlacementInfos == null)
            {
                return;
            }

            writer.BaseWriter.Write(PlacementInfos.Count);
            foreach (var placementInfo in PlacementInfos)
            {
                writer.Write(placementInfo.PlacementTagIndex);
                writer.Write(placementInfo.RelativePositionIndex);
                writer.Write(placementInfo.RelativeRotationIndex);
                writer.Write(placementInfo.Flags);
            }
        }

        if (propertyName == "eventsSortedByRUID")
        {
            if (EventsSortedByRUID == null)
            {
                return;
            }

            writer.BaseWriter.Write(EventsSortedByRUID.Count);
            foreach (var eventInfo in EventsSortedByRUID)
            {
                writer.Write(eventInfo.EventRUID);
                writer.Write(eventInfo.PlacementIndexMask);
                writer.Write(eventInfo.ComponentIndexMask);
                writer.Write(eventInfo.Flags);
                writer.BaseWriter.Write(new byte[] { 0, 0, 0, 0, 0, 0, 0 });
            }
        }
    }
}