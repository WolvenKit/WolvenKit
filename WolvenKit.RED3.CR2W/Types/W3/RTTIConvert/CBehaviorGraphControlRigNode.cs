using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphControlRigNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("eHandLeftW")] 		public CName EHandLeftW { get; set;}

		[Ordinal(2)] [RED("eHandLeftP")] 		public CName EHandLeftP { get; set;}

		[Ordinal(3)] [RED("eHandRightW")] 		public CName EHandRightW { get; set;}

		[Ordinal(4)] [RED("eHandRightP")] 		public CName EHandRightP { get; set;}

		[Ordinal(5)] [RED("offsetHandLeft")] 		public CBool OffsetHandLeft { get; set;}

		[Ordinal(6)] [RED("offsetHandRight")] 		public CBool OffsetHandRight { get; set;}

		[Ordinal(7)] [RED("eHandLeftWeaponOffset")] 		public CName EHandLeftWeaponOffset { get; set;}

		[Ordinal(8)] [RED("eHandRightWeaponOffset")] 		public CName EHandRightWeaponOffset { get; set;}

		public CBehaviorGraphControlRigNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphControlRigNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}