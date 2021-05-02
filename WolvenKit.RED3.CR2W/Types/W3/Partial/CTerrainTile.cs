using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CTerrainTile : CResource
	{
		[Ordinal(1)] [RED("tileFileVersion")] 		public CUInt32 TileFileVersion { get; set;}

		[Ordinal(2)] [RED("collisionType")] 		public CEnum<ETerrainTileCollision> CollisionType { get; set;}

		[Ordinal(3)] [RED("maxHeightValue")] 		public CUInt16 MaxHeightValue { get; set;}

		[Ordinal(4)] [RED("minHeightValue")] 		public CUInt16 MinHeightValue { get; set;}


	}
}
