using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphControlRigNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("eHandLeftW")] 		public CName EHandLeftW { get; set;}

		[Ordinal(0)] [RED("("eHandLeftP")] 		public CName EHandLeftP { get; set;}

		[Ordinal(0)] [RED("("eHandRightW")] 		public CName EHandRightW { get; set;}

		[Ordinal(0)] [RED("("eHandRightP")] 		public CName EHandRightP { get; set;}

		[Ordinal(0)] [RED("("offsetHandLeft")] 		public CBool OffsetHandLeft { get; set;}

		[Ordinal(0)] [RED("("offsetHandRight")] 		public CBool OffsetHandRight { get; set;}

		[Ordinal(0)] [RED("("eHandLeftWeaponOffset")] 		public CName EHandLeftWeaponOffset { get; set;}

		[Ordinal(0)] [RED("("eHandRightWeaponOffset")] 		public CName EHandRightWeaponOffset { get; set;}

		public CBehaviorGraphControlRigNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphControlRigNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}