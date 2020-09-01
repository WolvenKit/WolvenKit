using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPathLibSettings : CVariable
	{
		[Ordinal(1)] [RED("agentCategoriesCount")] 		public CUInt32 AgentCategoriesCount { get; set;}

		[Ordinal(2)] [RED("agentCategoryRadius1")] 		public CFloat AgentCategoryRadius1 { get; set;}

		[Ordinal(3)] [RED("agentCategoryRadius2")] 		public CFloat AgentCategoryRadius2 { get; set;}

		[Ordinal(4)] [RED("agentCategoryRadius3")] 		public CFloat AgentCategoryRadius3 { get; set;}

		[Ordinal(5)] [RED("agentCategoryRadius4")] 		public CFloat AgentCategoryRadius4 { get; set;}

		[Ordinal(6)] [RED("roadsNavcostMultiplier")] 		public CFloat RoadsNavcostMultiplier { get; set;}

		[Ordinal(7)] [RED("maxTerrainSlope")] 		public CFloat MaxTerrainSlope { get; set;}

		[Ordinal(8)] [RED("seaLevel")] 		public CFloat SeaLevel { get; set;}

		[Ordinal(9)] [RED("desiredStreamingRange")] 		public CFloat DesiredStreamingRange { get; set;}

		[Ordinal(10)] [RED("terrainWalkableRegionMinSize")] 		public CFloat TerrainWalkableRegionMinSize { get; set;}

		[Ordinal(11)] [RED("terrainUnwalkableRegionMinSize")] 		public CFloat TerrainUnwalkableRegionMinSize { get; set;}

		[Ordinal(12)] [RED("terrainNavmeshSurroundedRegionMinSize")] 		public CFloat TerrainNavmeshSurroundedRegionMinSize { get; set;}

		[Ordinal(13)] [RED("terrainHeightApproximationRange")] 		public CFloat TerrainHeightApproximationRange { get; set;}

		public CPathLibSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPathLibSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}