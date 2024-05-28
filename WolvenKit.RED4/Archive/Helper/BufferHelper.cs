using System.Diagnostics.CodeAnalysis;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive;

public static class BufferHelper
{
    private static readonly Dictionary<string, Type> s_bufferReaders = new();

    static BufferHelper()
    {
        s_bufferReaders.Add("appearanceAppearanceDefinition.compiledData", typeof(appearanceAppearanceDefinitionReader));
        s_bufferReaders.Add("entEntityTemplate.compiledData", typeof(entEntityTemplateReader));
        s_bufferReaders.Add("inkWidgetLibraryItem.package", typeof(CR2WWrapperReader));
        s_bufferReaders.Add("inkWidgetLibraryItem.packageData", typeof(RedPackageReader));
        s_bufferReaders.Add("entEntityInstanceData.buffer", typeof(RedPackageReader));
        s_bufferReaders.Add("gamePersistentStateDataResource.buffer", typeof(RedPackageReader));
        s_bufferReaders.Add("meshMeshMaterialBuffer.rawData", typeof(CR2WListReader));
        s_bufferReaders.Add("entEntityParametersBuffer.parameterBuffers", typeof(CR2WListReader));
        s_bufferReaders.Add("animAnimDataChunk.buffer", typeof(AnimationReader));
        s_bufferReaders.Add("worldNavigationTileResource.tileBuffers", typeof(TilesReader));
        s_bufferReaders.Add("worldSharedDataBuffer.buffer", typeof(WorldSharedDataBufferReader));
        s_bufferReaders.Add("worldStreamingSector.transforms", typeof(worldNodeDataReader));
        s_bufferReaders.Add("worldCollisionNode.compiledData", typeof(CollisionReader));
        s_bufferReaders.Add("worldFoliageDestructionNode.compiledData", typeof(CollisionReader));
        //s_bufferReaders.Add("physicsGeometryCache.bufferTableSectors", typeof(GeometryCacheReader));
        //s_bufferReaders.Add("physicsGeometryCache.alwaysLoadedSectorDDB", typeof(GeometryCacheReader));
        s_bufferReaders.Add("CGIDataResource.data", typeof(CGIDataReader));
        s_bufferReaders.Add("worldFoliageCompiledResource.dataBuffer", typeof(FoliageReader));
        
        s_bufferReaders.Add("animFacialSetup.bakedData", typeof(AnimFacialSetupBakedDataReader));
        s_bufferReaders.Add("animFacialSetup.mainPosesData", typeof(AnimFacialSetupMainPosesDataReader));
        s_bufferReaders.Add("animFacialSetup.correctivePosesData", typeof(AnimFacialSetupCorrectivePosesDataReader));

        // Save
        s_bufferReaders.Add("gameSavedStatsData.forcedModifiersBuffer", typeof(ModifiersBufferReader));
        s_bufferReaders.Add("gameSavedStatsData.modifiersBuffer", typeof(ModifiersBufferReader));
        s_bufferReaders.Add("gameSavedStatsData.savedModifierGroupStatTypesBuffer", typeof(SavedModifierGroupStatTypesBufferReader));

        // REDmod
        s_bufferReaders.Add("CMesh.metadata", typeof(CR2WListReader)); // actually just a single one, to lazy...
    }

    public static bool TryGetReader(RedBuffer buffer, [NotNullWhen(true)] out IBufferReader? reader)
    {
        reader = null;

        if (buffer.ParentTypes.Count != 1)
        {
            return false;
        }

        var parentType = buffer.ParentTypes.First();
        if (s_bufferReaders.TryGetValue(parentType, out var bufferReader))
        {
            var ms = new MemoryStream(buffer.GetBytes());
            if (System.Activator.CreateInstance(bufferReader, ms) is not IBufferReader tmpReader)
            {
                return false;
            }

            reader = tmpReader;
            return true;
        }

        return false;
    }
}