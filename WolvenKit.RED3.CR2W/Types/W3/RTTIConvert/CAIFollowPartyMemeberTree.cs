using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFollowPartyMemeberTree : CAIIdleTree
	{
		[Ordinal(1)] [RED("followPartyMember")] 		public CName FollowPartyMember { get; set;}

		[Ordinal(2)] [RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[Ordinal(3)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		public CAIFollowPartyMemeberTree(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}