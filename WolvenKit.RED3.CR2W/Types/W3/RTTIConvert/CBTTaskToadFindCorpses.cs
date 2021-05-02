using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadFindCorpses : IBehTreeTask
	{
		[Ordinal(1)] [RED("corpsesArray", 2,0)] 		public CArray<CHandle<CGameplayEntity>> CorpsesArray { get; set;}

		[Ordinal(2)] [RED("closestCorpse")] 		public CHandle<CGameplayEntity> ClosestCorpse { get; set;}

		[Ordinal(3)] [RED("searchRange")] 		public CFloat SearchRange { get; set;}

		[Ordinal(4)] [RED("maxResults")] 		public CInt32 MaxResults { get; set;}

		[Ordinal(5)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(6)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(7)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(8)] [RED("tempMinDist")] 		public CFloat TempMinDist { get; set;}

		[Ordinal(9)] [RED("minDist")] 		public CFloat MinDist { get; set;}

		[Ordinal(10)] [RED("closestCorpsePos")] 		public Vector ClosestCorpsePos { get; set;}

		public CBTTaskToadFindCorpses(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}