using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPathLibSettings : CVariable
	{
		[Ordinal(0)] [RED("("agentCategoriesCount")] 		public CUInt32 AgentCategoriesCount { get; set;}

		[Ordinal(0)] [RED("("agentCategoryRadius1")] 		public CFloat AgentCategoryRadius1 { get; set;}

		[Ordinal(0)] [RED("("agentCategoryRadius2")] 		public CFloat AgentCategoryRadius2 { get; set;}

		[Ordinal(0)] [RED("("agentCategoryRadius3")] 		public CFloat AgentCategoryRadius3 { get; set;}

		[Ordinal(0)] [RED("("agentCategoryRadius4")] 		public CFloat AgentCategoryRadius4 { get; set;}

		[Ordinal(0)] [RED("("roadsNavcostMultiplier")] 		public CFloat RoadsNavcostMultiplier { get; set;}

		[Ordinal(0)] [RED("("maxTerrainSlope")] 		public CFloat MaxTerrainSlope { get; set;}

		[Ordinal(0)] [RED("("seaLevel")] 		public CFloat SeaLevel { get; set;}

		[Ordinal(0)] [RED("("desiredStreamingRange")] 		public CFloat DesiredStreamingRange { get; set;}

		[Ordinal(0)] [RED("("terrainWalkableRegionMinSize")] 		public CFloat TerrainWalkableRegionMinSize { get; set;}

		[Ordinal(0)] [RED("("terrainUnwalkableRegionMinSize")] 		public CFloat TerrainUnwalkableRegionMinSize { get; set;}

		[Ordinal(0)] [RED("("terrainNavmeshSurroundedRegionMinSize")] 		public CFloat TerrainNavmeshSurroundedRegionMinSize { get; set;}

		[Ordinal(0)] [RED("("terrainHeightApproximationRange")] 		public CFloat TerrainHeightApproximationRange { get; set;}

		public CPathLibSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPathLibSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}