using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphControlRigNode : CBehaviorGraphBaseNode
	{
		[RED("eHandLeftW")] 		public CName EHandLeftW { get; set;}

		[RED("eHandLeftP")] 		public CName EHandLeftP { get; set;}

		[RED("eHandRightW")] 		public CName EHandRightW { get; set;}

		[RED("eHandRightP")] 		public CName EHandRightP { get; set;}

		[RED("offsetHandLeft")] 		public CBool OffsetHandLeft { get; set;}

		[RED("offsetHandRight")] 		public CBool OffsetHandRight { get; set;}

		[RED("eHandLeftWeaponOffset")] 		public CName EHandLeftWeaponOffset { get; set;}

		[RED("eHandRightWeaponOffset")] 		public CName EHandRightWeaponOffset { get; set;}

		public CBehaviorGraphControlRigNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphControlRigNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}