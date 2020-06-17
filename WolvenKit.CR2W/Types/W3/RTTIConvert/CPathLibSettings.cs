using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPathLibSettings : CVariable
	{
		[RED("agentCategoriesCount")] 		public CUInt32 AgentCategoriesCount { get; set;}

		[RED("agentCategoryRadius1")] 		public CFloat AgentCategoryRadius1 { get; set;}

		[RED("agentCategoryRadius2")] 		public CFloat AgentCategoryRadius2 { get; set;}

		[RED("agentCategoryRadius3")] 		public CFloat AgentCategoryRadius3 { get; set;}

		[RED("agentCategoryRadius4")] 		public CFloat AgentCategoryRadius4 { get; set;}

		[RED("roadsNavcostMultiplier")] 		public CFloat RoadsNavcostMultiplier { get; set;}

		[RED("maxTerrainSlope")] 		public CFloat MaxTerrainSlope { get; set;}

		[RED("seaLevel")] 		public CFloat SeaLevel { get; set;}

		[RED("desiredStreamingRange")] 		public CFloat DesiredStreamingRange { get; set;}

		[RED("terrainWalkableRegionMinSize")] 		public CFloat TerrainWalkableRegionMinSize { get; set;}

		[RED("terrainUnwalkableRegionMinSize")] 		public CFloat TerrainUnwalkableRegionMinSize { get; set;}

		[RED("terrainNavmeshSurroundedRegionMinSize")] 		public CFloat TerrainNavmeshSurroundedRegionMinSize { get; set;}

		[RED("terrainHeightApproximationRange")] 		public CFloat TerrainHeightApproximationRange { get; set;}

		public CPathLibSettings(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CPathLibSettings(cr2w);

	}
}