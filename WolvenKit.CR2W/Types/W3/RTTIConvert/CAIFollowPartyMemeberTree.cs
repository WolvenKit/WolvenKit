using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFollowPartyMemeberTree : CAIIdleTree
	{
		[RED("followPartyMember")] 		public CName FollowPartyMember { get; set;}

		[RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[RED("moveType")] 		public EMoveType MoveType { get; set;}

		public CAIFollowPartyMemeberTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIFollowPartyMemeberTree(cr2w);

	}
}