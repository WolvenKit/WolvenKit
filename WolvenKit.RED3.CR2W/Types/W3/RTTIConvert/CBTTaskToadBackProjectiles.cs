using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadBackProjectiles : CBTTaskProjectileAttackWithPrepare
	{
		[Ordinal(1)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(2)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(3)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(4)] [RED("animEvent", 2,0)] 		public CArray<CName> AnimEvent { get; set;}

		[Ordinal(5)] [RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[Ordinal(6)] [RED("projectilesShot")] 		public CBool ProjectilesShot { get; set;}

		[Ordinal(7)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskToadBackProjectiles(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}